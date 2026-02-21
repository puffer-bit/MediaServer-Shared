using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record ApproveUserResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Approve;
}