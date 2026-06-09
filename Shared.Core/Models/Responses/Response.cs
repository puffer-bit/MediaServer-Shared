using Shared.Enums;

namespace Shared.Models.Responses;

public abstract record Response : BaseMessage
{
    public Guid RequestId { get; init; } = Guid.NewGuid();
}