using Shared.Enums;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record SendMessageResponse(
    string RequestId,
    AddMessageResult Result) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Approve;
}