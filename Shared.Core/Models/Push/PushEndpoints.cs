using System.ComponentModel.DataAnnotations;
using Shared.Validation;

namespace Shared.Models.Push;

/// <summary>
/// The HTTP side of push notifications, served on the address and port of the coordinator.
/// A device sends here without a connection, with the reply token it got on registering.
/// </summary>
public static class PushEndpoints
{
    /// <summary>
    /// <c>POST</c> with a <see cref="PushReplyRequest"/> body sends a text message to a chat as the
    /// user the device is registered for. Answers 204 when it was added, 400 for a body that is not
    /// valid, 401 for a token that is unknown, 403 when the user may not write there, 404 for a chat
    /// that does not exist and 429 for too many replies.
    /// </summary>
    public const string Reply = "/push/reply";
}

public sealed record PushReplyRequest(
    [property: EntityId] int ChatId,
    [property: Required, NotBlank, StringLength(Limits.ChatTextMaxLength), NoControlCharacters(allowLineBreaks: true)] string Text);
