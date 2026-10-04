using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Shared.Models;
using Xunit;

namespace Shared.Tests;

/// <summary>
/// Every message travels as <see cref="BaseMessage"/>, so System.Text.Json can only write and read
/// the concrete types listed in its <see cref="JsonDerivedTypeAttribute"/> registrations.
/// </summary>
public class BaseMessageRegistrationTests
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    private static readonly JsonDerivedTypeAttribute[] Registrations =
        typeof(BaseMessage).GetCustomAttributes<JsonDerivedTypeAttribute>().ToArray();

    public static TheoryData<Type> ConcreteMessageTypes()
    {
        var data = new TheoryData<Type>();
        foreach (var type in typeof(BaseMessage).Assembly.GetTypes()
                     .Where(t => typeof(BaseMessage).IsAssignableFrom(t) && !t.IsAbstract)
                     .OrderBy(t => t.FullName))
            data.Add(type);
        return data;
    }

    [Theory]
    [MemberData(nameof(ConcreteMessageTypes))]
    public void ConcreteMessage_IsRegistered(Type type)
    {
        Assert.True(Registrations.Any(r => r.DerivedType == type),
            $"{type.Name} is not registered as a JsonDerivedType of BaseMessage");
    }

    [Fact]
    public void Discriminators_MatchTypeNames()
    {
        foreach (var registration in Registrations)
            Assert.Equal(registration.DerivedType.Name, registration.TypeDiscriminator);
    }

    [Fact]
    public void Discriminators_AreUnique()
    {
        var duplicates = Registrations
            .GroupBy(r => r.TypeDiscriminator)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();

        Assert.Empty(duplicates);
    }

    [Theory]
    [MemberData(nameof(ConcreteMessageTypes))]
    public void ConcreteMessage_RoundTripsThroughBaseMessage(Type type)
    {
        // The constructor is skipped on purpose: the test is about the type map, not about values.
        var message = (BaseMessage)RuntimeHelpers.GetUninitializedObject(type);

        var json = JsonSerializer.Serialize(message, JsonOptions);
        var restored = JsonSerializer.Deserialize<BaseMessage>(json, JsonOptions);

        Assert.NotNull(restored);
        Assert.Equal(type, restored.GetType());
        Assert.Equal(json, JsonSerializer.Serialize(restored, JsonOptions));
    }
}
