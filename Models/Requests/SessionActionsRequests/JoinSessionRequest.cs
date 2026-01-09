using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record JoinSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public SessionRequestType Type => SessionRequestType.Join;

        public JoinSessionResponse ToResponse(JoinSessionResult result)
            => new(SessionId, SessionType, result);
    }
}
