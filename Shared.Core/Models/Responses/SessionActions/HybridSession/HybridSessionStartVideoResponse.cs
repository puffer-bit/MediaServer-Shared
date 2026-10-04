using Shared.Enums;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public record HybridSessionStartVideoResponse(
    Guid RequestId,
    StartVideoShareResult Result,
    Outbound? Outbound) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVideoShare;
}