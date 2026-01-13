using Shared.Enums;
using Shared.Models.Responses.Sessions;

namespace Shared.Models.Responses.SessionActions;

public record KickFromSessionResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Kick;
}
