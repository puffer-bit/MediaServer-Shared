using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.Generic.Models;

public abstract record CreateSessionData
{
    public abstract SessionType SessionType { get; init; }
}