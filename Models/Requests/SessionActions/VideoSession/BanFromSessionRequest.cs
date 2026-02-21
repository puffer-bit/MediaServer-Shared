using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record BanFromSessionRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    string? Reason
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public SessionRequestType Type => SessionRequestType.Ban;

    public BanFromSessionResponse ToResponse(BanFromSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}