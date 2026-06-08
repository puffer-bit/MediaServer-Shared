using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record KickFromSessionRequest(
        int SessionId,
        int UserTargetId,
        SessionType SessionType,
        string? Reason
    ) : GenericSessionRequest
    {        
        public override SessionActionType ActionType { get; init; } = SessionActionType.KickRequest;

        public KickFromSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, UserTargetId, SessionType, result);
    }
}
