using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions;

public record BanFromSessionRequest(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    string? Reason
)
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
    public SessionRequestType Type => SessionRequestType.Ban;

    public BanFromVideoSessionResponse ToResponse(BanFromSessionResult result)
        => new(RequestId, SessionId, UserTargetId, SessionType, result);
}