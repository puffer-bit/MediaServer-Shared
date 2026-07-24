using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SessionsUpdatedNotification(SessionsStateChangedType NotificationType) : Notification;


public abstract record SessionCreatedNotification(SessionsStateChangedType NotificationType, SessionDTO Session) 
    : SessionsUpdatedNotification(NotificationType);

public abstract record SessionReconfiguredNotification(SessionsStateChangedType NotificationType, SessionDTO Session) 
    : SessionsUpdatedNotification(NotificationType);

public abstract record SessionDeletedNotification(SessionsStateChangedType NotificationType, int SessionId) 
    : SessionsUpdatedNotification(NotificationType);


public record HybridSessionCreatedNotification(SessionDTO Session)
    : SessionCreatedNotification(SessionsStateChangedType.HybridSessionCreated, Session);

public record ChatSessionCreatedNotification(SessionDTO Session)
    : SessionCreatedNotification(SessionsStateChangedType.ChatSessionCreated, Session);


public record HybridSessionReconfiguredNotification(SessionDTO Session)
    : SessionReconfiguredNotification(SessionsStateChangedType.HybridSessionReconfigured, Session);

public record ChatSessionReconfiguredNotification(SessionDTO Session)
    : SessionReconfiguredNotification(SessionsStateChangedType.ChatSessionReconfigured, Session);


public record HybridSessionDeletedNotification(int SessionId)
    : SessionDeletedNotification(SessionsStateChangedType.HybridSessionDeleted, SessionId);

public record ChatSessionDeletedNotification(int SessionId)
    : SessionDeletedNotification(SessionsStateChangedType.ChatSessionDeleted, SessionId);