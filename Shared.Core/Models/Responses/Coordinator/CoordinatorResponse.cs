using Shared.Enums;

namespace Shared.Models.Responses.Coordinator;

public abstract record CoordinatorResponse(Guid RequestId) : Response(RequestId)
{
    public abstract CoordinatorActionType ActionType { get; init; }
}