using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public record HybridSessionLeaveResponse(
    Guid RequestId,
    HybridSessionLeaveResult Result) 
    : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.Join;
}