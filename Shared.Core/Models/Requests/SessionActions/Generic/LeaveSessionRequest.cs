using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record LeaveSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType { get; init; } = SessionActionType.LeaveRequest;

        public LeaveSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
