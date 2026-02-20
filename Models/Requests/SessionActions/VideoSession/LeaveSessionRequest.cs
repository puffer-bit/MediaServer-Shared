using Shared.Enums;
using Shared.Models.Responses.SessionActions;

namespace Shared.Models.Requests.SessionActions
{
    public record LeaveSessionRequest(
        string SessionId,
        SessionType SessionType
    )
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        public SessionRequestType Type => SessionRequestType.Leave;

        public LeaveVideoSessionResponse ToResponse(LeaveSessionResult result)
            => new(RequestId, SessionId, SessionType, result);
    }
}
