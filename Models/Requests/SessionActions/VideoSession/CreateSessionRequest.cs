using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions
{
    public record CreateSessionRequest(
        CreateSessionModel CreateSessionModel
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Create;
        public CreateSessionResponse ToResponse(CreateSessionResult result, SessionDTO? sessionDTO)
            => new(RequestId, sessionDTO, result);
    }
}
