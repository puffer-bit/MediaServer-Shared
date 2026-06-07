using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record JoinSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType => SessionActionType.JoinRequest;

        public JoinSessionResponse ToResponse(JoinSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
