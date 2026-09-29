namespace Shared.Models.DataTransferObjects;

public record MediasoupTransportOptions
{
    public int Id { get; set; }
    public string Ip { get; set; } = string.Empty;
    public int Port { get; set; }
    public string RtpCapabilitiesJson { get; set; } = string.Empty;
    public object? DtlsParameters { get; set; }
}