namespace Shared.Models.Responses.SFUNegotiation;

public record TransportData(
    string Id,
    string? Ip,
    int? Port,
    string DtlsParametersJson,
    List<Inbound>? Inbounds
);
