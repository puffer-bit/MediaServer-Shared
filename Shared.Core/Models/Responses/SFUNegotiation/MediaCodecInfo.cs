namespace Shared.Models.Responses.SFUNegotiation;
    
public record MediaCodecInfo
{
    public int ClockRate { get; init; }
    public int PreferredPayloadType { get; init; }
    public MediaType MediaType { get; init; }
    public Dictionary<string, object> Parameters { get; init; } = new();
}