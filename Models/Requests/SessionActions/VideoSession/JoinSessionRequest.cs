using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions
{
    public record JoinSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Join;

        public JoinVideoSessionResponse ToResponse(JoinSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
