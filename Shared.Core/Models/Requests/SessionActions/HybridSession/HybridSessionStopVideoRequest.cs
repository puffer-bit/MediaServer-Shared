using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStopVideoRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVideoShare;
    
    public HybridSessionStopVideoResponse ToResponse(StopVideoShareResult result) 
        => new (RequestId, result);
}