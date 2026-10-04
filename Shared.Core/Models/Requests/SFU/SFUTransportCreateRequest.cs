using Shared.Enums;
using Shared.Models.Responses.SFU;
using Shared.Models.Responses.SFU.Connection;

namespace Shared.Models.Requests.SFU
{
    public record SFUTransportCreateRequest(
        int SessionId) : SFURequest
    {
        public SFUTransportCreateResponse ToResponse(SFUTransportCreateResult result,
            TransportData? transportData = null)
            => new(RequestId, SessionId, result, transportData);
    }
}
