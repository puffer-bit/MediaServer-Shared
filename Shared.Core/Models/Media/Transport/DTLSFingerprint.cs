namespace Shared.Models.Media.Transport;

public record DTLSFingerprint
{
    public required string Algorithm { get; init; }
    public required string Fingerprint { get; init; }
}
