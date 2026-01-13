using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record CreateSessionRequest(
        CreateSessionModel CreateSessionModel
    )
    {
        public SessionRequestType Type => SessionRequestType.Create;
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        
        public CreateSessionResponse ToResponse(CreateSessionResult result, SessionDTO? sessionDTO)
            => new(RequestId, sessionDTO, result);
    }
}
