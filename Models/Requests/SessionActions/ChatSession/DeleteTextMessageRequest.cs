using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record DeleteTextMessageRequest(
    int ChatId,
    int MessageId
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.DeleteMessage;

    public DeleteMessageResponse ToResponse(DeleteMessageResult result)
        => new(RequestId, result);
}