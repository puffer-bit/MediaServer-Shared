using Shared.Enums;
using Shared.Models.Requests.SessionActions.HybridSession;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record HybridSessionJoinRequest(
        int SessionId
    ) : HybridSessionRequest
    {
        public override HybridSessionActionType ActionType => HybridSessionActionType.Join;

        public DTLSParameters DtlsParameters { get; init; }
        
        public HybridSessionJoinResponse ToResponse(HybridSessionJoinResult result, TransportData? transportData = null)
            => new(RequestId, result, transportData);
    }
}
