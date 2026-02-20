using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record JoinSessionResponse(
    string RequestId,
    string SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Join;
}
