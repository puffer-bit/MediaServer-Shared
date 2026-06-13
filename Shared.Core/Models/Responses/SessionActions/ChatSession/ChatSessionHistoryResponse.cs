using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record ChatSessionHistoryResponse(
    Guid RequestId,
    FetchMessagesResult Result,
    List<ChatMessageDTO>? Messages) : ChatSessionResponse(RequestId)
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.ChatHistory;
}