using Shared.Enums;

namespace Shared.Models.Responses.Heartbeat;

public abstract record HeartbeatResponse(Guid RequestId) : Response(RequestId)
{
    public abstract HeartbeatActionType ActionType { get; init; }
}