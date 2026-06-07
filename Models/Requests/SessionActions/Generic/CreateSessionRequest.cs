using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record CreateSessionRequest(
        CreateSessionModel CreateSessionModel
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType => SessionActionType.CreateRequest;
        public CreateSessionResponse ToResponse(CreateSessionResult result, SessionDTO? sessionDTO)
            => new(RequestId, sessionDTO, result);
    }
}
