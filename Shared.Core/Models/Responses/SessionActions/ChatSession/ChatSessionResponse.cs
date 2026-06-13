using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public abstract record ChatSessionResponse(Guid RequestId) : Response(RequestId)
{
    public abstract ChatSessionActionType ActionType { get; init; }
}