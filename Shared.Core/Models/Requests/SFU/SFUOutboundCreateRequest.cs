using Shared.Enums;
using Shared.Models.Responses.SFU;

namespace Shared.Models.Requests.SFU;

public record SFUOutboundCreateRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundCreateResponse ToResponse(SFUOutboundCreateResult result, Outbound? outbound = null)
        => new(RequestId, SessionId, result, outbound);
}