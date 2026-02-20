using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record JoinVideoSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Join;
}
