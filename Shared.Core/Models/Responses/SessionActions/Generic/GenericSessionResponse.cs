using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.Generic;

public abstract record GenericSessionResponse : Response
{
    public abstract SessionActionType ActionType { get; init; }
}