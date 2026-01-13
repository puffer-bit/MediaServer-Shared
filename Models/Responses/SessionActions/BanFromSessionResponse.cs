using Shared.Enums;
using Shared.Models.Responses.Sessions;

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
