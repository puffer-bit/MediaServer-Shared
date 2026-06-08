using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record DeleteSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType { get; init; } = SessionActionType.DeleteRequest;

        public DeleteSessionResponse ToResponse(DeleteSessionResult result)
            => new(RequestId, result);
    }
}
