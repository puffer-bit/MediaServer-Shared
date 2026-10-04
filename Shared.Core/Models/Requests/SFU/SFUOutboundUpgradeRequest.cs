using Shared.Enums;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Requests.SFU;

public record SFUOutboundUpgradeRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundUpgradeResponse ToResponse(SFUOutboundUpgradeResult result)
        => new(RequestId, SessionId, result);
}