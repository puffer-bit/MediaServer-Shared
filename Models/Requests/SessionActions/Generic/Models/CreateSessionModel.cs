namespace Shared.Models.Requests.SessionActions;

public record CreateSessionModel(
    string Name,
    int HostId,
    int Capacity,
    CreateSessionData SessionData
);
