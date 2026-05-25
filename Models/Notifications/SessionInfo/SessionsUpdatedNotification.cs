using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SessionsUpdatedNotification(SessionsStateChangedType Type);

public record SessionCreatedNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.SessionCreated);

public record SessionReconfiguredNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.SessionReconfigured);

public record SessionDeletedNotification(int SessionId)
    : SessionsUpdatedNotification(SessionsStateChangedType.SessionDeleted);

