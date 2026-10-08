using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Shared.Enums;
using Shared.Enums.WebRTC;
using Shared.Models;
using Shared.Models.DataTransferObjects.ChatSession.Messages.Content;
using Shared.Models.Media.Transport;
using Shared.Models.Requests;
using Shared.Models.Requests.Auth;
using Shared.Models.Requests.Coordinator;
using Shared.Models.Requests.SessionActions.ChatSession;
using Shared.Models.Requests.SessionActions.ChatSession.Models;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.SessionActions.Generic.Models;
using Shared.Models.Requests.SessionActions.Generic.Models.SessionData;
using Shared.Models.Requests.SessionActions.HybridSession;
using Shared.Validation;
using Xunit;

namespace Shared.Tests;

public class MessageValidatorTests
{
    // Media attachments are not implemented yet: whether they become links or object storage
    // keys is undecided, so their fields get limits once that is settled
    private static readonly HashSet<Type> PendingMediaTypes =
    [
        typeof(ChatImageContentDTO),
        typeof(ChatVideoContentDTO),
        typeof(ChatFileContentDTO)
    ];

    private static readonly Assembly SharedAssembly = typeof(BaseMessage).Assembly;

    public static TheoryData<Type> ConcreteRequestTypes()
    {
        var data = new TheoryData<Type>();
        foreach (var type in SharedAssembly.GetTypes()
                     .Where(t => typeof(Request).IsAssignableFrom(t) && !t.IsAbstract)
                     .OrderBy(t => t.FullName))
            data.Add(type);
        return data;
    }

    [Theory]
    [MemberData(nameof(ConcreteRequestTypes))]
    public void EveryStringAndCollection_InARequest_HasASizeLimit(Type requestType)
    {
        var unbounded = new List<string>();
        var visited = new HashSet<Type>();
        CollectUnbounded(requestType, requestType.Name, unbounded, visited);

        Assert.True(unbounded.Count == 0, "No size limit on: " + string.Join(", ", unbounded));
    }

    [Theory]
    [MemberData(nameof(ConcreteRequestTypes))]
    public void Validator_HandlesEmptyRequestsWithoutThrowing(Type requestType)
    {
        var request = RuntimeHelpers.GetUninitializedObject(requestType);

        MessageValidator.TryValidate(request, out _);
    }

    [Fact]
    public void TypicalRequests_AreValid()
    {
        object[] requests =
        [
            new UserAuthRequest("secret", "alice"),
            new CoordinatorUserInfoRequest([1, 2, 3]),
            new CoordinatorChangeUsernameRequest("alice"),
            new CreateSessionRequest(new CreateSessionModel("Room", 10, new HybridSessionCreateData(WebRTCEngine.Mediasoup))),
            new CreateSessionRequest(new CreateSessionModel("Chat", 50, new ChatSessionCreateData("About\nus", "https://example.com/icon.png"))),
            new KickFromSessionRequest(1, 2, SessionType.Hybrid, "spam"),
            new SessionInfoRequest(null),
            new ChatSessionHistoryRequest(1, 50, 0),
            new EditTextMessageRequest(1, 2, "fixed\ttypo"),
            new SendTextMessageRequest(1, new NewChatMessageModel { ChatId = 1, TextContent = new ChatTextContentDTO { Text = "hi" }, ReplyToMessageId = 5 }),
            new HybridSessionJoinRequest(1) { ClientEpoch = Guid.NewGuid().ToString("N") },
            ConnectTransport(new DTLSFingerprint { Algorithm = "sha-256", Fingerprint = "AB:CD:EF:01" })
        ];

        foreach (var request in requests)
            Assert.True(MessageValidator.TryValidate(request, out var errors), $"{request.GetType().Name}: {string.Join("; ", errors)}");
    }

    public static TheoryData<object, string> InvalidRequests() => new()
    {
        { new UserAuthRequest("secret", new string('a', Limits.UserIdentityMaxLength + 1)), "UserIdentity" },
        { new CoordinatorUserInfoRequest(Enumerable.Range(1, Limits.UserIdsMaxCount + 1).ToList()), "UserIds" },
        { new CoordinatorUserInfoRequest([]), "UserIds" },
        { new CoordinatorChangeUsernameRequest(new string('u', Limits.UsernameMaxLength + 1)), "Username" },
        { new CoordinatorChangeUsernameRequest("   "), "Username" },
        { new CoordinatorChangeUsernameRequest("bad\u0007name"), "Username" },
        { new CreateSessionRequest(new CreateSessionModel(new string('n', Limits.SessionNameMaxLength + 1), 10, new ChatSessionCreateData())), "Name" },
        { new CreateSessionRequest(new CreateSessionModel("   ", 10, new ChatSessionCreateData())), "Name" },
        { new CreateSessionRequest(new CreateSessionModel("bad\u0007name", 10, new ChatSessionCreateData())), "Name" },
        { new CreateSessionRequest(new CreateSessionModel("Room", 0, new ChatSessionCreateData())), "Capacity" },
        { new CreateSessionRequest(new CreateSessionModel("Room", 10, new ChatSessionCreateData(IconPath: "file:///etc/passwd"))), "IconPath" },
        { new CreateSessionRequest(new CreateSessionModel("Room", 10, new HybridSessionCreateData((WebRTCEngine)99))), "EngineType" },
        { new CreateSessionRequest(new CreateSessionModel("Room", 10, new HybridSessionCreateData(WebRTCEngine.Mediasoup, VideoBitrate: 1_000_000))), "VideoBitrate" },
        { new KickFromSessionRequest(1, 2, SessionType.Hybrid, new string('r', Limits.ReasonMaxLength + 1)), "Reason" },
        { new DeleteSessionRequest(0), "SessionId" },
        { new ChatSessionHistoryRequest(1, Limits.ChatHistoryMaxTake + 1, 0), "Take" },
        { new EditTextMessageRequest(1, 2, new string('t', Limits.ChatTextMaxLength + 1)), "Text" },
        { new SendTextMessageRequest(1, new NewChatMessageModel { ChatId = 1 }), "text or an attachment" },
        { new SendTextMessageRequest(1, new NewChatMessageModel { ChatId = 1, TextContent = new ChatTextContentDTO { Text = "" } }), "Text" },
        { new SendTextMessageRequest(1, new NewChatMessageModel { ChatId = 1, TextContent = new ChatTextContentDTO { Text = "x" }, IsDelayed = true }), "DelayedSentTime" },
        { new SendTextMessageRequest(1, new NewChatMessageModel { ChatId = 1, TextContent = new ChatTextContentDTO { Text = "x" }, IsDisposable = true, DisposeTime = DateTime.UtcNow.AddYears(5) }), "DisposeTime" },
        { new HybridSessionJoinRequest(1) { ClientEpoch = "not-a-guid" }, "ClientEpoch" },
        { ConnectTransport(new DTLSFingerprint { Algorithm = "md5", Fingerprint = "AB:CD" }), "Fingerprints[0]" },
        { ConnectTransport(new DTLSFingerprint { Algorithm = "sha-256", Fingerprint = "<script>" }), "Fingerprints[0]" },
    };

    [Theory]
    [MemberData(nameof(InvalidRequests))]
    public void InvalidRequests_AreRejected(object request, string expectedInError)
    {
        Assert.False(MessageValidator.TryValidate(request, out var errors));
        Assert.Contains(errors, error => error.Contains(expectedInError, StringComparison.OrdinalIgnoreCase));
    }

    private static HybridSessionConnectTransportRequest ConnectTransport(DTLSFingerprint fingerprint) =>
        new(1) { DtlsParameters = new DTLSParameters { Role = "client", Fingerprints = [fingerprint] } };

    private static void CollectUnbounded(Type type, string path, List<string> unbounded, HashSet<Type> visited)
    {
        if (!visited.Add(type) || PendingMediaTypes.Contains(type))
            return;

        foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
            var propertyPath = $"{path}.{property.Name}";
            var bounded = property.GetCustomAttributes<ValidationAttribute>()
                .Any(a => a is StringLengthAttribute or ItemCountAttribute or OneOfAttribute);

            if (propertyType == typeof(string))
            {
                if (!bounded)
                    unbounded.Add(propertyPath);
                continue;
            }

            if (typeof(IEnumerable).IsAssignableFrom(propertyType))
            {
                if (!bounded)
                    unbounded.Add(propertyPath);

                var elementType = propertyType.IsArray
                    ? propertyType.GetElementType()
                    : propertyType.GetGenericArguments().FirstOrDefault();
                if (elementType != null)
                    CollectNested(elementType, propertyPath + "[]", unbounded, visited);
                continue;
            }

            CollectNested(propertyType, propertyPath, unbounded, visited);
        }
    }

    private static void CollectNested(Type type, string path, List<string> unbounded, HashSet<Type> visited)
    {
        if (type.Assembly != SharedAssembly || type.IsEnum)
            return;

        // A polymorphic property may hold any derived type, so each of them is checked
        foreach (var candidate in SharedAssembly.GetTypes().Where(t => type.IsAssignableFrom(t) && !t.IsAbstract))
            CollectUnbounded(candidate, path, unbounded, visited);
    }
}
