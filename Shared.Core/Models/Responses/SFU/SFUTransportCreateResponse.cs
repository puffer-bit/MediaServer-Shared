using Shared.Enums;

namespace Shared.Models.Responses.SFUNegotiation
{
    public record SFUTransportCreateResponse(
        Guid RequestId, 
        int SessionId, 
        SFUTransportCreateResult Result,
        TransportData? TransportData
    ) : SFUResponse(RequestId)
    {
        
    }
}
