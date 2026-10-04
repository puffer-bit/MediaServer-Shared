using Shared.Enums;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public record HybridSessionStartVoiceResponse(
    Guid RequestId,
    StartVoiceShareResult Result,
    Outbound? Outbound) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVoiceShare;
}