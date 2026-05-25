namespace Shared.Models.Requests.SessionActions;

public record CreateSessionModel(
    string Name,
    int HostId,
    int Capacity,
    ICreateSessionData Data
);
