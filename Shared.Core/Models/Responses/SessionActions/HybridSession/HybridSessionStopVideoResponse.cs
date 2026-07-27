using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStopVideoResponse(
    Guid RequestId,
    StopVideoShareResult Result) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StopVideoShare;
}