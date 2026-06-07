using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record BanFromSessionResponse(
    string RequestId,
    int SessionId,
    int UserTargetId,
    SessionType SessionType,
    BanFromSessionResult Result ) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.BanRequest;
}
