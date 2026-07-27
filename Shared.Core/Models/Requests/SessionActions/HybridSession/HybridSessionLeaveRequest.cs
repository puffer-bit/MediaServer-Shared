using Shared.Enums;
using Shared.Models.Requests.SessionActions.HybridSession;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record HybridSessionLeaveRequest(
        int SessionId
    ) : HybridSessionRequest
    {
        public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.Join;
        
        public HybridSessionLeaveResponse ToResponse(HybridSessionLeaveResult result)
            => new(RequestId, result);
    }
}
