using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat.Messages;
using Shared.Models.Responses.SessionActions.TextChat;

namespace Shared.Models.Requests.SessionActions.TextChat;

public record ChatSessionHistoryRequest(
    int ChatId,
    int Take,
    int? Skip
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.ChatHistory;
    
    public TextChatHistoryResponse ToResponse(FetchMessagesResult result, List<ChatMessageDTO>? messages)
        => new(RequestId, messages, result);
}