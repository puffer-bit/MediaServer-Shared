using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation;

public record SFUOutboundUpgradeRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundUpgradeResponse ToResponse(SFUOutboundUpgradeResult result)
        => new(RequestId, SessionId, result);
}