namespace Shared.Models.Responses.SFU.Connection;

public record ICEParameters
{
    public required string UsernameFragment { get; init; }
    public required string Password { get; init; }
    public required List<ICECandidate> ICECandidates { get; init; }
}