using Shared.Enums;
using Shared.Models.Responses;
using Shared.Models.Responses.WebRTCNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public record WebRtcNegotiationRequest(
        string RequestId,
        WebRtcActionType ActionType, int SessionId, object Data, bool IsGstWebRTC = false) : WebRtcRequest
    {
        public WebRtcNegotiationResponse ToResponse(WebRtcActionType type, WebRTCNegotiationResult result,
            object data)
            => new(RequestId, type, SessionId, data, result, IsGstWebRTC);
    }
}
