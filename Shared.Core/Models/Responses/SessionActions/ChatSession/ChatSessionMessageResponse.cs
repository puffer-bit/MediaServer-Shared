using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record ChatSessionMessageResponse(
    string RequestId,
    ChatMessageDTO? Message,
    FetchMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.MessageRequest;
}