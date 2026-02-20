using Shared.Enums;

namespace Shared.Models.Requests.SessionActions;

public record CreateSessionModel(
    string Name,
    string HostId,
    int Capacity,
    SessionType SessionType
);
