using Shared.Enums;
using Shared.Models.Responses.SessionActions.HybridSession;

namespace Shared.Models.Requests.SessionActions.HybridSession
{
    public record HybridSessionLeaveRequest(
        int SessionId
    ) : HybridSessionRequest
    {
        public override HybridSessionActionType ActionType => HybridSessionActionType.Leave;

        public HybridSessionLeaveResponse ToResponse(HybridSessionLeaveResult result)
            => new(RequestId, result);
    }
}
