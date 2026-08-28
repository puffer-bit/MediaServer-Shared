using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStartVoiceResponse(
    Guid RequestId,
    StartVoiceShareResult Result,
    Outbound? Outbound) : HybridSessionResponse(RequestId)
{
    public override HybridSessionActionType ActionType { get; init; } = HybridSessionActionType.StartVoiceShare;
}