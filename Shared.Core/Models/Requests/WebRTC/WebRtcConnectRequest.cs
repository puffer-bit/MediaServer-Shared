using Shared.Enums;
using Shared.Models.Responses;
using Shared.Models.Responses.WebRTCNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public record WebRtcConnectRequest(int SessionId, string Data, bool IsGstWebRTC = false) : WebRtcRequest
    {
        public WebRtcConnectResponse ToResponse(WebRTCNegotiationResult result, string? data)
            => new(RequestId, SessionId, data, result, IsGstWebRTC);
    }
}
