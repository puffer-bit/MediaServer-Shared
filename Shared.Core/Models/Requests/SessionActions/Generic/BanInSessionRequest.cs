using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic;

public record BanInSessionRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    string? Reason
) : GenericSessionRequest
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.BanRequest;

    public BanInSessionResponse ToResponse(BanFromSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}