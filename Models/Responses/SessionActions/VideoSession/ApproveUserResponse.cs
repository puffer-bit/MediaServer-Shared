using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record ApproveUserResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Approve;
}