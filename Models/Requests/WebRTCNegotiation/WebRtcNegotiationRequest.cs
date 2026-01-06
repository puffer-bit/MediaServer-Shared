using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses;
using Shared.Models.Responses.WebRTCNegotiation;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public record WebRtcNegotiationRequest(
        WebRtcNegotiationType Type, string SessionId, object Data)
    {
        public WebRtcNegotiationResponse ToResponse(WebRtcNegotiationType type, WebRTCNegotiationResult result,
            object data)
            => new(type, SessionId, data, result);
    }
}
