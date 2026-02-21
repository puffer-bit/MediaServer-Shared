using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record CreateSessionModel(
    string Name,
    string HostId,
    int Capacity,
    SessionType SessionType
);
