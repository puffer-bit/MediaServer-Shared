using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record KickFromSessionRequest(
        int SessionId,
        int UserTargetId,
        SessionType SessionType,
        string? Reason
    ) : GenericSessionRequest
    {        
        public override SessionActionType ActionType => SessionActionType.KickRequest;

        public KickFromSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, UserTargetId, SessionType, result);
    }
}
