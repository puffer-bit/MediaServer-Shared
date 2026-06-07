using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record ApproveUserRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType
) : GenericSessionRequest
{
    public override SessionActionType ActionType => SessionActionType.ApproveRequest;
    
    public ApproveUserResponse ToResponse(ApproveUserSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}

