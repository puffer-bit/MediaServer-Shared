using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record LeaveSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Leave;
}
