namespace Shared.Models.Responses.SFUNegotiation;
    
public record Outbound
{
    public int? SSRC { get; set; }
    public Dictionary<MediaType, MediaCodecInfo> MediaInfo { get; init; }
    public MediaSourceType SourceType { get; init; }
}