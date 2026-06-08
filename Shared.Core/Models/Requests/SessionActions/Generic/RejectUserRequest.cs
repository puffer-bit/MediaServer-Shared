using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic;

public record RejectUserRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    string? Reason
) : GenericSessionRequest
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.RejectRequest;

    public RejectUserResponse ToResponse(RejectUserSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}