using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record ApproveUserResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.ApproveRequest;
}