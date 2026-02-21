using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record TextChatHistoryRequest(
    string ChatId,
    int Take,
    int? Skip
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public TextChatRequestType Type => TextChatRequestType.ChatHistory;
    
    public TextChatHistoryResponse ToResponse(TextChatHistoryResult result, List<ChatMessageDTO> messages)
        => new(RequestId, messages, result);
}