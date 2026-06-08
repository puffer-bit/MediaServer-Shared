using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;
using Shared.Models.DTO.TextChat.Messages;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record TextChatHistoryResponse(
    string RequestId,
    List<ChatMessageDTO>? Messages,
    FetchMessagesResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.ChatHistory;
}