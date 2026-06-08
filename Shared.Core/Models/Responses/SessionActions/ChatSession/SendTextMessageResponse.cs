using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.ChatSession;

public record SendMessageResponse(
    string RequestId,
    AddMessageResult Result) : ChatSessionResponse
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.SendMessage;
}