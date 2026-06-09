using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.Responses.Heartbeat;

namespace Shared.Models.Requests.Heartbeat;

public record HeartbeatPingRequest() : HeartbeatRequest
{
    public override HeartbeatActionType ActionType { get; init; } = HeartbeatActionType.Ping;
    
    public HeartbeatPingResponse ToResponse(long timestamp) 
        => new(RequestId, timestamp);
}