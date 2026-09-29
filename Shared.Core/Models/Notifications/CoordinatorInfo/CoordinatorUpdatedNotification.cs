using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Notifications.SessionInfo;

namespace Shared.Models.Notifications.CoordinatorInfo;

public abstract record CoordinatorUpdatedNotification(CoordinatorStateChangedType NotificationType) : Notification;

public record CoordinatorReconfiguredNotification(CoordinatorSessionDTO CoordinatorSessionDTO)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.CoordinatorReconfigured);