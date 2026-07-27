using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public abstract record HybridSessionRequest : Request
{
    public abstract HybridSessionActionType ActionType { get; init; }
}