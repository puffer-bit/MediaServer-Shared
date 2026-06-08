using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record RejectUserResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    RejectUserSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.RejectRequest;
}
