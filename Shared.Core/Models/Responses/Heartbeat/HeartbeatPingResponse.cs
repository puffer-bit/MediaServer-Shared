using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatPingResponse(
    string RequestId,
    int UserId,
    long Timestamp) : HeartbeatResponse
{
    public override HeartbeatActionType ActionType => HeartbeatActionType.Ping;
}