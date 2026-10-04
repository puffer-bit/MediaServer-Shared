namespace Shared.Models.Responses.SFU.Connection;

public record TransportData(
    string Host,
    ushort Port,
    DTLSParameters DTLSData,
    ICEParameters ICEData
);
