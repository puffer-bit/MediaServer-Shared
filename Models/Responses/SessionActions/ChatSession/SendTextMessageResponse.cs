using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record SendMessageResponse(
    string RequestId,
    AddMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType => ChatSessionActionType.SendMessage;
}