using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record CreateSessionModel(
    string Name,
    int HostId,
    int Capacity,
    ICreateSessionData Data
);
