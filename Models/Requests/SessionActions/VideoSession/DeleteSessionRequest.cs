using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions
{
    public record DeleteSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Delete;

        public DeleteVideoSessionResponse ToResponse(DeleteSessionResult result)
            => new(RequestId, result);
    }
}
