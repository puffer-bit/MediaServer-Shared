using Shared.Enums;

namespace Shared.Models.Responses;

public abstract record Response
{
    public string RequestId { get; init; } = null!;
}