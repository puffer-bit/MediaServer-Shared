using Shared.Enums;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorRequest : Request
{
    public virtual CoordinatorActionType ActionType { get; init; }
}