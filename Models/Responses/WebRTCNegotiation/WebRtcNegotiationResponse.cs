using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcNegotiationResponse(
    WebRtcNegotiationType Type,
    string SessionId,
    object? Data,
    WebRTCNegotiationResult Result);