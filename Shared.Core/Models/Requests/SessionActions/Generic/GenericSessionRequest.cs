using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.Generic;

public abstract record GenericSessionRequest : Request
{
    public abstract SessionActionType ActionType { get; init; }
}