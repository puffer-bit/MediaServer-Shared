using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record JoinSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType { get; init; } = SessionActionType.JoinRequest;

        public JoinSessionResponse ToResponse(JoinSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
