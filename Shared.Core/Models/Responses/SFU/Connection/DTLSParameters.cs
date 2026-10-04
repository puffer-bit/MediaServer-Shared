namespace Shared.Models.Responses.SFU.Connection;

public record DTLSParameters
{
    public required string Role { get; init; }
    public required List<DTLSFingerprint> Fingerprints { get; init; }
}