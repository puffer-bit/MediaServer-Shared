using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record BanFromVideoSessionResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Ban;
}
