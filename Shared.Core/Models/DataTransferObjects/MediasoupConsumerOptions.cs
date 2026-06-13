namespace Server.Shared.MediaSoup;

public record MediasoupConsumerOptions
{
    public string ConsumerId { get; set; }
    public string ProducerId { get; set; }
    public string Kind { get; set; }
    public object RtpParameters { get; set; }
}
