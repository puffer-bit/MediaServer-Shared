using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record LeaveSessionResponse(
    string SessionId,
    SessionType SessionType,
    LeaveSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Leave;
}
