using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Responses.SessionActions.Generic;

public record JoinSessionResponse(
    Guid RequestId,
    int SessionId,
    SessionType SessionType,
    JoinSessionResult Result,
    TransportData? TransportData) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.JoinRequest;
}
