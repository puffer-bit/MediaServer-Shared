using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStartVideoRequest(
    int? SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVideoShare;
    
    public HybridSessionStartVideoResponse ToResponse(StartVideoShareResult result) 
        => new (RequestId, result);
}