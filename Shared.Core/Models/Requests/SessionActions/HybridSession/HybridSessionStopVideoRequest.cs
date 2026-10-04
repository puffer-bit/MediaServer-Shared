using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStopVideoRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.StopVideoShare;

    public HybridSessionStopVideoResponse ToResponse(StopVideoShareResult result)
        => new (RequestId, result);
}
