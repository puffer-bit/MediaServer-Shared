using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record BanFromSessionResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Ban;
}
