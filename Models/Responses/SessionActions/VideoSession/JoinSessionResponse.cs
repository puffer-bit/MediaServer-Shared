using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record JoinSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Join;
}
