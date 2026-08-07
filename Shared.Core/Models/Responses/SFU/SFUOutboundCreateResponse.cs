using Shared.Enums;

namespace Shared.Models.Responses.SFUNegotiation
{
    public record SFUOutboundCreateResponse(
        Guid RequestId, 
        int SessionId, 
        SFUOutboundCreateResult Result,
        Outbound Outbound
    ) : SFUResponse(RequestId)
    {
        
    }
}
