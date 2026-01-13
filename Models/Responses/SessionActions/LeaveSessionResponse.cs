using Shared.Enums;
using Shared.Models.Responses.Sessions;

namespace Shared.Models.Responses.SessionActions;

public record LeaveSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Leave;
}
