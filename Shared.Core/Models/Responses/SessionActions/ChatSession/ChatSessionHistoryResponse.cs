using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record ChatSessionHistoryResponse(
    string RequestId,
    List<ChatMessageDTO>? Messages,
    FetchMessagesResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.ChatHistory;
}