using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record RejectUserRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    string? Reason
) : GenericSessionRequest
{
    public override SessionActionType ActionType => SessionActionType.RejectRequest;

    public RejectUserResponse ToResponse(RejectUserSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}