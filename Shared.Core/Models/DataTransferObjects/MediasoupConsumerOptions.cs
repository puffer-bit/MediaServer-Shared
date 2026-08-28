namespace Shared.Models.DataTransferObjects;

public record MediasoupConsumerOptions
{
    public string ConsumerId { get; set; }
    public string ProducerId { get; set; }
    public string Kind { get; set; }
    public object RtpParameters { get; set; }
}
