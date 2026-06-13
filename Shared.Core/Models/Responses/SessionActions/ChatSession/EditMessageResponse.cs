using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record EditMessageResponse(
    Guid RequestId,
    EditMessageResult Result) : ChatSessionResponse(RequestId)
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.EditMessage;
}