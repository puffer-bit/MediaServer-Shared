using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.DataTransferObjects.ChatSession;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SessionsUpdatedNotification(SessionsStateChangedType NotificationType) : Notification;

public record HybridSessionCreatedNotification(HybridSessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionCreated);

public record HybridSessionReconfiguredNotification(HybridSessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionReconfigured);

public record HybridSessionDeletedNotification(int SessionId)
    : SessionsUpdatedNotification(SessionsStateChangedType.HybridSessionDeleted);

public record ChatSessionCreatedNotification(ChatSessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionCreated);

public record ChatSessionReconfiguredNotification(ChatSessionDTO Session)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionReconfigured);

public record ChatSessionDeletedNotification(int SessionId)
    : SessionsUpdatedNotification(SessionsStateChangedType.ChatSessionDeleted);
    