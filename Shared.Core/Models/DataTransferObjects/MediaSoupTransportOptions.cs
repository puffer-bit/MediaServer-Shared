namespace Server.Shared.MediaSoup;

public record MediasoupTransportOptions
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public int Port { get; set; }
    public string RtpCapabilitiesJson { get; set; }
    public object DtlsParameters { get; set; }
}