using Shared.Enums.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record ChatSessionRequest : Request
{
    public virtual ChatSessionActionType ActionType { get; init; }
}