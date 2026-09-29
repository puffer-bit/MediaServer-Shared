using Shared.Enums;
using Shared.Models.Responses.SessionActions.HybridSession;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionSetMicrophoneMuteRequest(
    int SessionId,
    bool IsMuted) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.ToggleMicrophoneMute;
    
    public HybridSessionSetMicrophoneMuteResponse ToResponse(SetMicrophoneMuteResult result) 
        => new (RequestId, result, IsMuted);
}