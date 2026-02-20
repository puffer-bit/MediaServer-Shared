using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record KickFromVideoSessionResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Kick;
}
