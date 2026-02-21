using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public interface IChatSessionResponse : IResponse
{
    TextChatRequestType Type { get; }
}