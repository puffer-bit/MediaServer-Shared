using Shared.Enums;
using Shared.Models.Responses;
using Shared.Models.Responses.WebRTCNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public record WebRtcNegotiationRequest(
        WebRtcActionType ActionType, int SessionId, string Data, bool IsGstWebRTC = false) : WebRtcRequest
    {
        public WebRtcNegotiationResponse ToResponse(WebRtcActionType type, WebRTCNegotiationResult result,
            string? data)
            => new(RequestId, type, SessionId, data, result, IsGstWebRTC);
    }
}
