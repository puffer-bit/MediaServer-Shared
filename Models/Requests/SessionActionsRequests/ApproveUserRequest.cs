using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests;

public record ApproveUserRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType
)
{
    public SessionRequestType Type => SessionRequestType.Approve;

    public ApproveUserResponse ToResponse(ApproveUserSessionResult result)
        => new(SessionId, UserTargetId, SessionType, result);
}

