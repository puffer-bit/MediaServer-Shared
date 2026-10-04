using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStartVoiceRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.StartVoiceShare;
    
    public HybridSessionStartVoiceResponse ToResponse(StartVoiceShareResult result, Outbound? outbound = null) 
        => new (RequestId, result, outbound);
}