using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record BanInSessionRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    string? Reason
) : GenericSessionRequest
{
    public override SessionActionType ActionType => SessionActionType.BanRequest;

    public BanFromSessionResponse ToResponse(BanFromSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}