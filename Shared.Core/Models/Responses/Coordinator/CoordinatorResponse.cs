using Shared.Enums;

namespace Shared.Models.Responses.Coordinator;

public record CoordinatorResponse
{
    public virtual CoordinatorActionType ActionType { get; init; }
}