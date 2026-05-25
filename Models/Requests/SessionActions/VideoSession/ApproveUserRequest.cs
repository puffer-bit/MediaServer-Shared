using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record ApproveUserRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public SessionRequestType Type => SessionRequestType.Approve;
    
    public ApproveUserResponse ToResponse(ApproveUserSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}

