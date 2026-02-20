using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions
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

        public KickFromVideoSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, UserTargetId, SessionType, result);
    }
}
