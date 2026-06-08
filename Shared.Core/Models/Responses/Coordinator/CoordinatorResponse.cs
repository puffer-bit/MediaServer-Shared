using Shared.Enums;

namespace Shared.Models.Responses.Coordinator;

public abstract record CoordinatorResponse : Response
{
    public abstract CoordinatorActionType ActionType { get; init; }
}