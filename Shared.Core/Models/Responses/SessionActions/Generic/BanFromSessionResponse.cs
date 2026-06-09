using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record BanFromSessionResponse(
    Guid RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.BanRequest;
}
