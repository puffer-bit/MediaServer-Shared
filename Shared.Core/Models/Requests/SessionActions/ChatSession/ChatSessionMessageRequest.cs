using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;
using Shared.Models.Responses.SessionActions.ChatSession;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public record ChatSessionMessageRequest(
    int ChatId,
    int MessageId
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.MessageRequest;
    
    public ChatSessionMessageResponse ToResponse(FetchMessageResult result, ChatMessageDTO? message)
        => new(RequestId, message, result);
}