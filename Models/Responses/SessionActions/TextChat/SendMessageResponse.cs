using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record SendMessageResponse(
    string RequestId,
    AddMessageResult Result) : ITextChatResponse
{
    public TextChatRequestType Type => TextChatRequestType.SendMessage;
}