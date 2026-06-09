using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Responses.SessionActions.Generic;

public record CreateSessionResponse(
    Guid RequestId,
    SessionDTO? Session,
    CreateSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.CreateRequest;
}
