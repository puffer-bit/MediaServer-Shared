using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionLeaveResponse(
    Guid RequestId,
    HybridSessionLeaveResult Result) 
    : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.Join;
}