using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record DeleteSessionResponse(
    string SessionId,
    SessionType SessionType,
    DeleteSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Delete;
}
