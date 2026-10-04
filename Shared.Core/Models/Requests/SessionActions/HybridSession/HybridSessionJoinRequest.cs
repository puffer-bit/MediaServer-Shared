using Shared.Enums;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Models.Responses.SFU.Connection;

namespace Shared.Models.Requests.SessionActions.HybridSession
{
    public record HybridSessionJoinRequest(
        int SessionId
    ) : HybridSessionRequest
    {
        public override HybridSessionActionType ActionType => HybridSessionActionType.Join;
        
        /// <summary>
        /// Identifies the DTLS context of the client. The SFU reuses an existing transport while
        /// this value stays the same and recreates it once the client has rebuilt its own side.
        /// </summary>
        public string? ClientEpoch { get; init; }
        
        public HybridSessionJoinResponse ToResponse(HybridSessionJoinResult result, TransportData? transportData = null)
            => new(RequestId, result, transportData);
    }
}
