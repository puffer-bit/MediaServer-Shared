using System.ComponentModel.DataAnnotations;
using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests;

public record RejectUserRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType
)
{
    public SessionRequestType Type => SessionRequestType.Reject;
    public string? Reason { get; init; }

    public RejectUserResponse ToResponse(RejectUserSessionResult result)
        => new(SessionId, UserTargetId, SessionType, result);
}