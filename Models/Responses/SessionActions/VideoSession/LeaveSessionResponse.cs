using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record LeaveSessionResponse(
    string RequestId,
    int SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Leave;
}
