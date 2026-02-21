using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record EditMessageResponse(
    string RequestId,
    EditMessageResult Result) : IChatSessionResponse
{
    public TextChatRequestType Type => TextChatRequestType.EditMessage;
}