using Shared.Enums;

namespace Shared.Models.Requests.SessionActionsRequests;

public record CreateSessionModel(
    string Name,
    string? HostId,
    int Capacity,
    SessionType SessionType
);
