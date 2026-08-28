using Shared.Enums;
using Shared.Models.DataTransferObjects.ChatSession.Messages;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record ChatSessionMessageResponse(
    Guid RequestId,
    ChatMessageDTO? Message,
    FetchMessageResult Result) : ChatSessionResponse(RequestId)
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.MessageRequest;
}