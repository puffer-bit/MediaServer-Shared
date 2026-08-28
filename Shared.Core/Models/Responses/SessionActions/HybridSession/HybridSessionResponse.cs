using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public abstract record HybridSessionResponse(Guid RequestId) : Response(RequestId)
{
    public abstract HybridSessionActionType ActionType { get; init; }
}