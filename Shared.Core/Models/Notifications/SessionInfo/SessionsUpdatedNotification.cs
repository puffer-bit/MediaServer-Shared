using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SessionsUpdatedNotification(SessionsStateChangedType NotificationType) : Notification;

public record HybridSessionCreatedNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionCreated);

public record HybridSessionReconfiguredNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionReconfigured);

public record HybridSessionDeletedNotification(int SessionId)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionDeleted);

public record ChatSessionCreatedNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionCreated);

public record ChatSessionReconfiguredNotification(SessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionReconfigured);

public record ChatSessionDeletedNotification(int SessionId)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionDeleted);