using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record LeaveVideoSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Leave;
}
