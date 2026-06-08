using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatPingRequest(
    int UserId) : HeartbeatRequest
{
    public override HeartbeatActionType ActionType => HeartbeatActionType.Ping;
    
    public HeartbeatPingResponse ToResponse(long timestamp) 
        => new(RequestId, UserId, timestamp);
}