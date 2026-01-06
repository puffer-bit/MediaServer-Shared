using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests;

public record BanFromSessionRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    string? Reason
)
{
    public SessionRequestType Type => SessionRequestType.Ban;

    public BanFromSessionResponse ToResponse(BanFromSessionResult result)
        => new(SessionId, UserTargetId, SessionType, result);
}