using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record RejectUserResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    RejectUserSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.RejectRequest;
}
