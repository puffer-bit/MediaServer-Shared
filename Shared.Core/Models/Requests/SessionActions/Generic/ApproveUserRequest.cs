using Shared.Enums;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.Generic;

public record ApproveUserRequest(
    int SessionId,
    int UserTargetId,
    SessionType SessionType
) : GenericSessionRequest
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.ApproveRequest;
    
    public ApproveUserResponse ToResponse(ApproveUserSessionResult result, TransportData? transportData = null)
        => new(RequestId, SessionId, UserTargetId, SessionType, result, transportData);
}

