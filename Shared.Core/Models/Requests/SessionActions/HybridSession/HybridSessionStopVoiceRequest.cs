using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStopVoiceRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.StopVoiceShare;
    
    public HybridSessionStopVoiceResponse ToResponse(StopVoiceShareResult result) 
        => new (RequestId, result);
}