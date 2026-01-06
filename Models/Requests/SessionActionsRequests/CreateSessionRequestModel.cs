using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record CreateSessionRequest(
        string SessionId,
        SessionDTO Session
    )
    {
        public SessionRequestType Type => SessionRequestType.Create;

        public CreateSessionResponse ToResponse(CreateSessionResult result)
            => new(SessionId, Session, result);
    }
}
