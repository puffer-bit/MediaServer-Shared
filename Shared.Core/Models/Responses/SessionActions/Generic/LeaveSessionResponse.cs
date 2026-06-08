using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record LeaveSessionResponse(
    string RequestId,
    int SessionId,
    SessionType SessionType,
    LeaveSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.LeaveRequest;
}
