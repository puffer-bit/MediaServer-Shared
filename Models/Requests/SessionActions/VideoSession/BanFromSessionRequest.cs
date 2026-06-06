using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record BanFromSessionRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    string? Reason
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public SessionRequestType ActionType => SessionRequestType.Ban;

    public BanFromSessionResponse ToResponse(BanFromSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}