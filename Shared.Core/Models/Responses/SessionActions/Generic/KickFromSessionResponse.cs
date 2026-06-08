using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record KickFromSessionResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.KickRequest;
}
