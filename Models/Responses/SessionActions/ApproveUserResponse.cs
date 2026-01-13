using Shared.Enums;
using Shared.Models.Responses.Sessions;

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