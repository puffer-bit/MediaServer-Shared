using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record KickFromSessionRequest(
        string SessionId,
        string UserTargetId,
        SessionType SessionType,
        string? Reason
    )
    {
        public SessionRequestType Type => SessionRequestType.Kick;

        public KickFromSessionResponse ToResponse(LeaveSessionResult result)
            => new(SessionId, UserTargetId, SessionType, result);
    }
}
