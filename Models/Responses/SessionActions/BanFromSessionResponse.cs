using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record BanFromSessionResponse(
    string RequestId,
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Ban;
}
