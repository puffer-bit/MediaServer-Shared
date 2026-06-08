using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record ChatSessionResponse
{
    public virtual ChatSessionActionType ActionType { get; init; }
}