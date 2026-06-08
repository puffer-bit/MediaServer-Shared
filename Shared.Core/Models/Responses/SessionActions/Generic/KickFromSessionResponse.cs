using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record KickFromSessionResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    LeaveSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.KickRequest;
}
