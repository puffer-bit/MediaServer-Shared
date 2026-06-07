using Shared.Enums;

namespace Shared.Models.Requests.SessionActions;

public record CreateSessionData
{
    public SessionType SessionType { get; }
}