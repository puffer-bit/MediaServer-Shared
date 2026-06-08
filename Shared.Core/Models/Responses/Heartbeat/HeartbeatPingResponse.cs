using Shared.Enums;

namespace Shared.Models.Responses.Heartbeat;

public record HeartbeatPingResponse(
    string RequestId,
    string ConnectionId,
    int? UserId,
    long Timestamp) : HeartbeatResponse
{
    public override HeartbeatActionType ActionType { get; init; } = HeartbeatActionType.Ping;
}