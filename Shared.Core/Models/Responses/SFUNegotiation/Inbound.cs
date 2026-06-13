namespace Shared.Models.Responses.SFUNegotiation;

public record Inbound
{
    public int UserId { get; init; }
    public int SSRC { get; init; }
    public Dictionary<MediaType, MediaCodecInfo> MediaInfo { get; init; }
    public MediaSourceType SourceType { get; init; }
}