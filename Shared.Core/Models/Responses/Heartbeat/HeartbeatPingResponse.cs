using Shared.Enums;

namespace Shared.Models.Responses.Heartbeat;

public record HeartbeatPingResponse(
    Guid RequestId,
    long Timestamp) : HeartbeatResponse
{
    public override HeartbeatActionType ActionType { get; init; } = HeartbeatActionType.Ping;
}