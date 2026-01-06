using System.ComponentModel.DataAnnotations;
using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests;

public record RejectUserRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    string? Reason
)
{
    public SessionRequestType Type => SessionRequestType.Reject;

    public RejectUserResponse ToResponse(RejectUserSessionResult result)
        => new(SessionId, UserTargetId, SessionType, result);
}