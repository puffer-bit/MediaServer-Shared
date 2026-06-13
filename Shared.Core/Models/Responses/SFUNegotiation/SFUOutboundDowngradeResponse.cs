using Shared.Enums;

namespace Shared.Models.Responses.SFUNegotiation
{
    public record SFUOutboundDowngradeResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundDowngradeResult Result
    ) : SFUResponse(RequestId)
    {
        
    }
}
