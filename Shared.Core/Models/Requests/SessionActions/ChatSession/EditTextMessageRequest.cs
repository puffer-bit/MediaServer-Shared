using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DataTransferObjects.TextChat.Messages;
using Shared.Models.Responses.SessionActions.ChatSession;

namespace Shared.Models.Requests.SessionActions.ChatSession;

public record EditTextMessageRequest(
    int ChatId,
    ChatMessageDTO Message
) : ChatSessionRequest
{
    public override ChatSessionActionType ActionType { get; init; } = ChatSessionActionType.EditMessage;

    public EditMessageResponse ToResponse(EditMessageResult result)
        => new(RequestId, result);
}