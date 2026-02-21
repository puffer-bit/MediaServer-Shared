using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record JoinSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Join;

        public JoinSessionResponse ToResponse(JoinSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
