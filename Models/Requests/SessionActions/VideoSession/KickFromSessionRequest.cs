using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record KickFromSessionRequest(
        string SessionId,
        string UserTargetId,
        SessionType SessionType,
        string? Reason
    )
    {        
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Kick;

        public KickFromSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, UserTargetId, SessionType, result);
    }
}
