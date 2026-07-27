using Shared.Enums;
using Shared.Models.Responses;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public abstract record HybridSessionResponse(Guid RequestId) : Response(RequestId)
{
    public abstract HybridSessionActionType ActionType { get; init; }
}