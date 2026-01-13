using Shared.Enums;

namespace Shared.Models.Responses.WebRTCNegotiation;

public record WebRtcNegotiationResponse(
    string RequestId,
    WebRtcNegotiationType Type,
    string SessionId,
    object? Data,
    WebRTCNegotiationResult Result) : IResponse;