namespace Shared.Models.Responses.SFUNegotiation;
    
public record Outbound
{
    public int? SSRC { get; set; }
    public MediaCodecInfo MediaInfo { get; init; }
    public MediaSourceType SourceType { get; init; }
}