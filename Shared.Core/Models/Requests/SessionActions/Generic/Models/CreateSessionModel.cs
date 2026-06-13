using Shared.Models.Requests.SessionActions.Generic.Models.SessionData;

namespace Shared.Models.Requests.SessionActions.Generic.Models;

public record CreateSessionModel(
    string Name,
    int HostId,
    int Capacity,
    CreateSessionData SessionData
);
