using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public class HeartbeatModel
{
    public required DateTime TimeStamp { get; set; }
    public required HeartbeatType ActionType { get; set; }
    public int Latency { get; set; }
    
    [SetsRequiredMembers]
    public HeartbeatModel(HeartbeatType type ,int latency = -1)
    {
        TimeStamp = DateTime.UtcNow;
        ActionType = type;
        Latency = latency;
    }
}