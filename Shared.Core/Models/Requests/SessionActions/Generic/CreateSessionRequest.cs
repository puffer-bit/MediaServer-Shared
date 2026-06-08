using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Requests.SessionActions.Generic.Models;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record CreateSessionRequest(
        CreateSessionModel CreateSessionModel
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType { get; init; } = SessionActionType.CreateRequest;
        public CreateSessionResponse ToResponse(CreateSessionResult result, SessionDTO? sessionDTO)
            => new(RequestId, sessionDTO, result);
    }
}
