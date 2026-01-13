using Shared.Enums;
using Shared.Models.Responses.Sessions;

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
