using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public record HybridSessionJoinResponse(
    Guid RequestId,
    HybridSessionJoinResult Result,
    TransportData? TransportData) 
    : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.Join;
}