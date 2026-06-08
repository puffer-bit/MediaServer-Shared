using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public abstract record ChatSessionResponse : Response
{
    public abstract ChatSessionActionType ActionType { get; init; }
}