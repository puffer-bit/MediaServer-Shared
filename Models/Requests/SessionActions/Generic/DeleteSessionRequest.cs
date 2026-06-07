using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record DeleteSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType => SessionActionType.DeleteRequest;

        public DeleteSessionResponse ToResponse(DeleteSessionResult result)
            => new(RequestId, result);
    }
}
