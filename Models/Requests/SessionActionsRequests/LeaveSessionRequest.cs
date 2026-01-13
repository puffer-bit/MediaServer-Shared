using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public record LeaveSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Leave;

        public LeaveSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
