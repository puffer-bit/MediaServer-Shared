using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record RejectUserResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    RejectUserSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Reject;
}
