using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record KickFromSessionResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType ActionType => SessionRequestType.Kick;
}
