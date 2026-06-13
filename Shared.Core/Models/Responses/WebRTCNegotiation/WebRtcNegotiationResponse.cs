using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcNegotiationResponse(
    Guid RequestId,
    WebRtcActionType ActionType,
    int SessionId,
    string? Data,
    WebRTCNegotiationResult Result,
    bool IsGstWebRTC) : WebRtcResponse(RequestId);