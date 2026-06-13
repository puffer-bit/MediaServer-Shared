namespace Shared.Models.Responses.SFUNegotiation;
    
public record MediaCodecInfo
{
    public string Kind { get; init; } = string.Empty;        
    public string MimeType { get; init; } = string.Empty;    
    public int ClockRate { get; init; }
    public int PreferredPayloadType { get; init; }
    public Dictionary<string, object>? Parameters { get; init; }
}