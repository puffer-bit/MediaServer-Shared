using Shared.Enums;

namespace Shared.Models.Responses.SFU
{
    public record SFUOutboundCreateResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundCreateResult Result,
        Outbound? Outbound
    ) : SFUResponse(RequestId)
    {
        
    }
}
