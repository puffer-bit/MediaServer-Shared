using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcConnectResponse(
    Guid RequestId,
    int SessionId,
    string? Data,
    WebRTCNegotiationResult Result,
    bool IsGstWebRTC) : WebRtcResponse(RequestId);