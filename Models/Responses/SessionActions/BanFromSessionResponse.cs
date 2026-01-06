using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record BanFromSessionResponse(
    string SessionId,
    string UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Ban;
}
