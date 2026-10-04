namespace Shared.Models.Media.Transport;

public record DTLSParameters
{
    public required string Role { get; init; }
    public required List<DTLSFingerprint> Fingerprints { get; init; }
}
