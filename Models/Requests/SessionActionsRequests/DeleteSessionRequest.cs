using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record DeleteSessionRequest(
        string SessionId
    )
    {
        public SessionRequestType Type => SessionRequestType.Delete;

        public DeleteSessionResponse ToResponse(DeleteSessionResult result)
            => new(result);
    }
}
