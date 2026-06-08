using Shared.Enums.TextChat;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public abstract record ChatSessionRequest : Request
{
    public abstract ChatSessionActionType ActionType { get; init; }
}