using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record EditTextMessageRequest(
    int ChatId,
    ChatMessageDTO Message
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.EditMessage;

    public EditMessageResponse ToResponse(EditMessageResult result)
        => new(RequestId, result);
}