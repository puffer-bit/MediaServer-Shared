using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public abstract record HeartbeatRequest : Request
{
    public abstract HeartbeatActionType ActionType { get; init; }
}