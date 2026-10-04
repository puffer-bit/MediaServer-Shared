using Shared.Enums;
using Shared.Models.Responses.WebRTC;

namespace Shared.Models.Requests.WebRTC;

public record WebRtcConnectRequest(int SessionId, string Data, bool IsGstWebRTC = false) : WebRtcRequest
{
    public WebRtcConnectResponse ToResponse(WebRTCNegotiationResult result, string? data)
        => new(RequestId, SessionId, data, result, IsGstWebRTC);
}
