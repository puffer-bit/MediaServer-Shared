using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record BanFromSessionResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType ActionType => SessionRequestType.Ban;
}
