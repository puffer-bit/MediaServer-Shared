using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record JoinSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Join;

        public JoinSessionResponse ToResponse(JoinSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
