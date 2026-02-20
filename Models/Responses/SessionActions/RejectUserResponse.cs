using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record RejectUserResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    RejectUserSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Reject;
}
