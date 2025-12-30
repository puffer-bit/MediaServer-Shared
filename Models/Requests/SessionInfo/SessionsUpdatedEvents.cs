using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionInfo;

public abstract record SessionsUpdatedEvent(SessionsStateChangedType Type);

public record SessionCreatedEvent(SessionDTO Session)
    : SessionsUpdatedEvent(SessionsStateChangedType.SessionCreated);

public record SessionReconfiguredEvent(SessionDTO Session)
    : SessionsUpdatedEvent(SessionsStateChangedType.SessionReconfigured);

public record SessionDeletedEvent(string SessionId)
    : SessionsUpdatedEvent(SessionsStateChangedType.SessionDeleted);

