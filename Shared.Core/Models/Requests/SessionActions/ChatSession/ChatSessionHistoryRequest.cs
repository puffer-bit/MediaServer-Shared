using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;
using Shared.Models.Responses.SessionActions.ChatSession;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public record ChatSessionHistoryRequest(
    int ChatId,
    int Take,
    int? Skip
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.ChatHistory;
    
    public ChatSessionHistoryResponse ToResponse(FetchMessagesResult result, List<ChatMessageDTO>? messages)
        => new(RequestId, messages, result);
}