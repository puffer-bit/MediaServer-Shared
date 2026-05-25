using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record TextChatMessageRequest(
    int ChatId,
    int MessageId
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.MessageRequest;
    
    public TextChatMessageResponse ToResponse(FetchMessageResult result, ChatMessageDTO? message)
        => new(RequestId, message, result);
}