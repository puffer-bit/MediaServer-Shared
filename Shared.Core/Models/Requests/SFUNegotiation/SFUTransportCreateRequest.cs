using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public record SFUTransportCreateRequest(
        int SessionId) : SFURequest
    {
        public SFUTransportCreateResponse ToResponse(SFUTransportCreateResult result,
            string? ip = null, int? port = null, TransportData? transportData = null)
            => new(RequestId, SessionId, result, transportData);
    }
}
