using Shared.Enums;

namespace Shared.Models.Responses.SFU
{
    public record SFUOutboundDowngradeResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundDowngradeResult Result
    ) : SFUResponse(RequestId)
    {
        
    }
}
