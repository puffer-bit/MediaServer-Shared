namespace Shared.Models.Responses.SFU.Connection;

public record DTLSFingerprint
{
    public required string Algorithm { get; init; }
    public required string Fingerprint { get; init; }
}