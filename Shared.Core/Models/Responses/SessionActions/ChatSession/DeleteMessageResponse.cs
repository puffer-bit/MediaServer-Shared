using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record DeleteMessageResponse(
    string RequestId,
    DeleteMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.DeleteMessage;
}