using Shared.Enums;
using Shared.Enums.TextChat;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.Responses.SessionActions.TextChat;

public record EditMessageResponse(
    string RequestId,
    EditMessageResult Result) : ISessionResponse
{
    // the session type for text chat actions is treated as an approval event
    public SessionRequestType Type => SessionRequestType.Approve;
}