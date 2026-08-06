namespace Shared.Models.Responses.SFUNegotiation;

public record DTLSFingerprint
{
    public required string Algorithm { get; init; }
    public required string Fingerprint { get; init; }
}