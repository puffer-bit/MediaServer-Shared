using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record EditTextMessageRequest(
    string ChatId,
    ChatMessageDTO Message
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.EditMessage;

    public EditMessageResponse ToResponse(EditMessageResult result)
        => new(RequestId, result);
}