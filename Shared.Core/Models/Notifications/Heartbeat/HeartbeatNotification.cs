using Shared.Enums;

namespace Shared.Models.Notifications.Heartbeat;

public record HeartbeatNotification(HeartbeatStateChangedType NotificationType) : Notification;

public record HeartbeatServerClosingNotification(string CoordinatorId, string? Message = null)
    : HeartbeatNotification(HeartbeatStateChangedType.ServerClosing);
    
public record HeartbeatServerRestartingNotification(string CoordinatorId, string? Message = null)
    : HeartbeatNotification(HeartbeatStateChangedType.ServerRestarting);