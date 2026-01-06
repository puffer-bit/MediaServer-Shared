using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record KickFromSessionResponse(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Kick;
}
