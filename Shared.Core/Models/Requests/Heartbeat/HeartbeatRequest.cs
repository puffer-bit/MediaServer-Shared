using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatRequest : Request
{
    public virtual HeartbeatActionType ActionType { get; init; }
}