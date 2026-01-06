using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record ApproveUserResponse(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Approve;
}