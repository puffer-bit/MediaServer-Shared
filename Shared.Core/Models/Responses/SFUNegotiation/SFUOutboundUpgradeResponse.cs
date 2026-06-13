using Shared.Enums;

namespace Shared.Models.Responses.SFUNegotiation
{
    public record SFUOutboundUpgradeResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundUpgradeResult Result
    ) : SFUResponse(RequestId)
    {
        
    }
}
