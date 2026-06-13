using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation;

public record SFUOutboundDowngradeRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundDowngradeResponse ToResponse(SFUOutboundDowngradeResult result)
        => new(RequestId, SessionId, result);
}