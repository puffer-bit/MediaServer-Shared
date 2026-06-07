using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatResponse
{
    public virtual HeartbeatActionType ActionType { get; init; }
}