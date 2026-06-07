using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcNegotiationResponse(
    string RequestId,
    WebRtcActionType ActionType,
    int SessionId,
    object? Data,
    WebRTCNegotiationResult Result,
    bool IsGstWebRTC) : WebRtcResponse;