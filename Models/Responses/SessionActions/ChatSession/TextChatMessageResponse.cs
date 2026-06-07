using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;
using Shared.Models.DTO.TextChat.Messages;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record TextChatMessageResponse(
    string RequestId,
    ChatMessageDTO? Message,
    FetchMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.MessageRequest;
}