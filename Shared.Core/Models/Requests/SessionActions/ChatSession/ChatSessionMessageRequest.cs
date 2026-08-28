using Shared.Enums;
using Shared.Models.DataTransferObjects.ChatSession.Messages;
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