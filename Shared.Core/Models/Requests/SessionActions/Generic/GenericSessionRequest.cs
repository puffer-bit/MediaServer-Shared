using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record GenericSessionRequest : Request
{
    public virtual SessionActionType ActionType { get; init; }
}