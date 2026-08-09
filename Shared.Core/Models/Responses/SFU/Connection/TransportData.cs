using Server.Shared.SFUService;

namespace Shared.Models.Responses.SFUNegotiation;

public record TransportData(
    string Host,
    ushort Port,
    DTLSParameters DTLSData,
    ICEParameters ICEData
);
