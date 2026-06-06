using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public interface IChatSessionResponse : IResponse
{
    TextChatRequestType ActionType { get; }
}