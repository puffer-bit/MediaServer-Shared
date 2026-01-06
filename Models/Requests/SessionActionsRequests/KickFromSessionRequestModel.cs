using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record KickFromSessionRequest(
        string SessionId,
        string UserTargetId,
        SessionType SessionType
    )
    {
        public SessionRequestType Type => SessionRequestType.Kick;
        public string? Reason { get; init; }

        public KickFromSessionResponse ToResponse(LeaveSessionResult result)
            => new(SessionId, UserTargetId, SessionType, result);
    }
}
