namespace Shared.Models.DataTransferObjects;

public record MediasoupConsumerOptions
{
    public string ConsumerId { get; set; } = string.Empty;
    public string ProducerId { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public object? RtpParameters { get; set; }
}
