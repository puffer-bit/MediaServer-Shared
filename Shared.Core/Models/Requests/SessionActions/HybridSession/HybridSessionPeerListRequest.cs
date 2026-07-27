using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionPeerListRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.PeerListRequest;
    
    public HybridSessionPeerListResponse ToResponse(PeerListRequestResult result, Dictionary<int, PeerDTO>? peers = null) 
        => new (RequestId, result, peers);
}