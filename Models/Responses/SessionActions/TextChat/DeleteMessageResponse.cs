using Shared.Enums;
using Shared.Enums.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record DeleteMessageResponse(
    string RequestId,
    DeleteMessageResult Result) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Approve;
}