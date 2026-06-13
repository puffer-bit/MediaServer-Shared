using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record LeaveSessionResponse(
    Guid RequestId,
    int SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.LeaveRequest;
}
