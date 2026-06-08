using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record JoinSessionResponse(
    string RequestId,
    int SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.JoinRequest;
}
