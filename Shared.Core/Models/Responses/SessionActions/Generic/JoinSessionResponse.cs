using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record JoinSessionResponse(
    string RequestId,
    int SessionId,
    SessionType SessionType,
    JoinSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.JoinRequest;
}
