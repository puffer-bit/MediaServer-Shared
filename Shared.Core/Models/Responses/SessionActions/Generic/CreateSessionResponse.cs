using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record CreateSessionResponse(
    string RequestId,
    SessionDTO? Session,
    CreateSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.CreateRequest;
}
