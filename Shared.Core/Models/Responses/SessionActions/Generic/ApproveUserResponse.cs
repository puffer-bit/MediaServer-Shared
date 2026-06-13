using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Responses.SessionActions.Generic;

public record ApproveUserResponse(
    Guid RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    ApproveUserSessionResult Result,
    TransportData? TransportData) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.ApproveRequest;
}