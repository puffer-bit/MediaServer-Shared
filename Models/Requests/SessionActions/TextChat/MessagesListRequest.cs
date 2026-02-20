using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions;

public record MessageListRequest(
    string ChatId,
    int Take,
    int? Skip
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.EditMessage;

    public EditMessageResponse ToResponse(EditMessageResult result)
        => new(RequestId, result);
}