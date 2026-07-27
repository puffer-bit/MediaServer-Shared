using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStartVideoResponse(
    Guid RequestId,
    StartVideoShareResult Result) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVideoShare;
}