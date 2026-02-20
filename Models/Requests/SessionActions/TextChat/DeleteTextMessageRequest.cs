using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions;

public record DeleteTextMessageRequest(
    string ChatId,
    string MessageId
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.DeleteMessage;

    public DeleteMessageResponse ToResponse(DeleteMessageResult result)
        => new(RequestId, result);
}