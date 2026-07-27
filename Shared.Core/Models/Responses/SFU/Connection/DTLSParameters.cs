namespace Shared.Models.Responses.SFUNegotiation;

public record DTLSParameters
{
    public required string Role { get; init; }
    public required List<DTLSFingerprint> DTLSFingerprints { get; init; }
}