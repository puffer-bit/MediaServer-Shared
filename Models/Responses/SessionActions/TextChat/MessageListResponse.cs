using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record MessageListResponse(
    string RequestId,
    List<ChatMessageDTO> Messages,
    AddMessageResult Result) : ITextChatResponse
{
    public TextChatRequestType Type => TextChatRequestType.DeleteMessage;
}