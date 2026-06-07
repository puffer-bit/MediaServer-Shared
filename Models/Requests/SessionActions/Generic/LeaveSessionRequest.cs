using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record LeaveSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType => SessionActionType.LeaveRequest;

        public LeaveSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
