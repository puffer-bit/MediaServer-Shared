using Shared.Enums;

namespace Shared.Models.Responses.Heartbeat;

public abstract record HeartbeatResponse : Response
{
    public abstract HeartbeatActionType ActionType { get; init; }
}