using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record ApproveUserResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Approve;
}