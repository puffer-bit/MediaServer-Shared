using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public record DeleteSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.DeleteRequest;
}
