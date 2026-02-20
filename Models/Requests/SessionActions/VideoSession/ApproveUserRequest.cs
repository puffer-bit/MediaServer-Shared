using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions;

public record ApproveUserRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public SessionRequestType Type => SessionRequestType.Approve;
    
    public ApproveUserResponse ToResponse(ApproveUserSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}

