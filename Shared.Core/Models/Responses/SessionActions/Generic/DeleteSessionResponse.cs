using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record DeleteSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.DeleteRequest;
}
