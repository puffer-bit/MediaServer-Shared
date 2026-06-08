using Shared.Enums;

namespace Shared.Models.Requests.Coordinator;

public abstract record CoordinatorRequest : Request
{
    public abstract CoordinatorActionType ActionType { get; init; }
}