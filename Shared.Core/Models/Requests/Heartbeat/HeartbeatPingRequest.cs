using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.Responses.Heartbeat;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatPingRequest(
    string ConnectionId,
    int? UserId) : HeartbeatRequest
{
    public override HeartbeatActionType ActionType { get; init; } = HeartbeatActionType.Ping;
    
    public HeartbeatPingResponse ToResponse(long timestamp) 
        => new(RequestId, ConnectionId, UserId, timestamp);
}