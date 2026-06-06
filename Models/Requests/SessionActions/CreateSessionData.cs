using Shared.Enums;

namespace Shared.Models.Requests.SessionActions;

public record CreateSessionData
{
    SessionType SessionType { get; }
}