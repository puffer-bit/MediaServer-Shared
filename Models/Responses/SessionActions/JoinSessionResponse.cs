using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record JoinSessionResponse(
    string SessionId,
    SessionType SessionType,
    JoinSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Join;
}
