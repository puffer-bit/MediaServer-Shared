using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Responses.SessionActions.Generic;

public record JoinSessionResponse(
    Guid RequestId,
    int SessionId,
    SessionType SessionType,
    JoinSessionResult Result,
    TransportData? Data) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType => SessionActionType.JoinRequest;
}
