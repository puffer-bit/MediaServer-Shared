using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionPeerListRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.PeerListRequest;
    
    public HybridSessionPeerListResponse ToResponse(PeerListRequestResult result, Dictionary<int, PeerDTO>? peers = null) 
        => new (RequestId, result, peers);
}