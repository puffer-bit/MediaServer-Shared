using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record GenericSessionResponse
{
    public virtual SessionActionType ActionType { get; init; }
}