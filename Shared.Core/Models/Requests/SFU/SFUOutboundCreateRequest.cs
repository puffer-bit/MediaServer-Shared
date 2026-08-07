using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation;

public record SFUOutboundCreateRequest(
    int SessionId, Outbound Outbound) : SFURequest
{
    public SFUOutboundCreateResponse ToResponse(SFUOutboundCreateResult result, Outbound? outbound = null)
        => new(RequestId, SessionId, result, outbound);
}