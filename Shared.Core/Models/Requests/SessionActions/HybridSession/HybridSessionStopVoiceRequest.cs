using System.ComponentModel.DataAnnotations;
using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Validation;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionStopVoiceRequest(
    [property: EntityId] int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.StopVoiceShare;

    public HybridSessionStopVoiceResponse ToResponse(StopVoiceShareResult result)
        => new (RequestId, result);
}
