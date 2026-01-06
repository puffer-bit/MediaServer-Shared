using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record RejectUserResponse(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    RejectUserSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Reject;
}
