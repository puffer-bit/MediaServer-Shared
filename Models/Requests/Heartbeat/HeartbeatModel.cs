using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.Heartbeat;

public class HeartbeatModel
{
    public required DateTime TimeStamp { get; set; }
    public required HeartbeatType Type { get; set; }
    public int? Latency { get; set; }
    
    [SetsRequiredMembers]
    public HeartbeatModel(HeartbeatType type ,int? latency = null)
    {
        TimeStamp = DateTime.UtcNow;
        Type = type;
        Latency = latency;
    }
}