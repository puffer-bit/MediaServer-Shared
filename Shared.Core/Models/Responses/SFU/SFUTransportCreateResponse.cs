using Shared.Enums;
using Shared.Models.Responses.SFU.Connection;

namespace Shared.Models.Responses.SFU
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
