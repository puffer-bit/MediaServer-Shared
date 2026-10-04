using Shared.Enums;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Requests.SFU;

public record SFUOutboundDowngradeRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundDowngradeResponse ToResponse(SFUOutboundDowngradeResult result)
        => new(RequestId, SessionId, result);
}