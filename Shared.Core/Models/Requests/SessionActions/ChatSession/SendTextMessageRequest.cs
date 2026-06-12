using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.Requests.SessionActions.ChatSession.Models;
using Shared.Models.Responses.SessionActions.ChatSession;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public record SendTextMessageRequest(
    int ChatId,
    NewChatMessageModel Message
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.SendMessage;
    
    public SendTextMessageResponse ToResponse(AddMessageResult result)
        => new(RequestId, result);
}