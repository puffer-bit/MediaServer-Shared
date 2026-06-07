using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record ChatSessionMessageRequest(
    int ChatId,
    int MessageId
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.MessageRequest;
    
    public TextChatMessageResponse ToResponse(FetchMessageResult result, ChatMessageDTO? message)
        => new(RequestId, message, result);
}