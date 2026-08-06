namespace Shared.Models.Responses.SFUNegotiation;

public record TransportData(
    string? ServerIp,
    int? ServerPort,
    DTLSParameters DTLSData,
    ICEParameters ICEData,
    List<Inbound>? Inbounds
);
