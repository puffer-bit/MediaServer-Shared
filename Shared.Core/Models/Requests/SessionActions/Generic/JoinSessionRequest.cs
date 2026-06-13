using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.Generic
{
    public record JoinSessionRequest(
        int SessionId,
        SessionType SessionType
    ) : GenericSessionRequest
    {
        public override SessionActionType ActionType { get; init; } = SessionActionType.JoinRequest;

        public JoinSessionResponse ToResponse(JoinSessionResult result, TransportData? transportData = null)
            => new(RequestId, SessionId, SessionType, result, transportData);
    }
}
