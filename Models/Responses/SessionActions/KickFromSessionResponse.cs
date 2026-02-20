using Shared.Enums;

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
