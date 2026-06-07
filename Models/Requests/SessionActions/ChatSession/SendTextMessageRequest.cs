using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record SendTextMessageRequest(
    int ChatId,
    NewChatMessageModel Message
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.SendMessage;
    
    public SendMessageResponse ToResponse(AddMessageResult result)
        => new(RequestId, result);
}