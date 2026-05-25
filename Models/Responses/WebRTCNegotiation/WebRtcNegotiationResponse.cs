using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcNegotiationResponse(
    string RequestId,
    WebRtcNegotiationType Type,
    int SessionId,
    object? Data,
    WebRTCNegotiationResult Result,
    bool IsGstWebRTC) : IResponse;