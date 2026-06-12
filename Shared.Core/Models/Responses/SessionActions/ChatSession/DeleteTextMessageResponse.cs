using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record DeleteTextMessageResponse(
    Guid RequestId,
    DeleteMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.DeleteMessage;
}