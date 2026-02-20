using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public interface ITextChatResponse : IResponse
{
    TextChatRequestType Type { get; }
}
