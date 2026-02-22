using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record SendTextMessageRequest(
    string ChatId,
    NewChatMessageModel Message
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.SendMessage;
    
    public SendMessageResponse ToResponse(AddMessageResult result)
        => new(RequestId, result);
}