using Shared.Enums;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions.VideoSession
{
    public record LeaveSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Leave;

        public LeaveSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
