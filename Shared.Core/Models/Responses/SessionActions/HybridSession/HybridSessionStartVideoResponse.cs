using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStartVideoResponse(
    Guid RequestId,
    StartVideoShareResult Result,
    Outbound? Outbound) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVideoShare;
}