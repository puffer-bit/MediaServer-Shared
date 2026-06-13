using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record JoinSessionResponse(
    Guid RequestId,
    int SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.JoinRequest;
}
