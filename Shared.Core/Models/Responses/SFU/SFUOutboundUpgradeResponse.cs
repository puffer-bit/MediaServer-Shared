using Shared.Enums;

namespace Shared.Models.Responses.SFU
{
    public record SFUOutboundUpgradeResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundUpgradeResult Result
    ) : SFUResponse(RequestId)
    {
        
    }
}
