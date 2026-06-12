using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.Responses.SessionActions.ChatSession;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public record DeleteTextMessageRequest(
    int ChatId,
    int MessageId
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.DeleteMessage;

    public DeleteTextMessageResponse ToResponse(DeleteMessageResult result)
        => new(RequestId, result);
}