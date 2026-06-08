using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Notifications.SessionInfo;

namespace Shared.Models.Notifications.CoordinatorInfo;

public abstract record CoordinatorUpdatedNotification(CoordinatorStateChangedType Type) : Notification;

public record CoordinatorUserListUpdatedNotification(IList<UserDTO> Users)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UsersListUpdated);

public record CoordinatorUserConnectedNotification(UserDTO User)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserConnected);

public record CoordinatorUserDisconnectedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserDisconnected);

public record CoordinatorUserKickedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserKicked);

public record CoordinatorUserBannedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserBanned);

public record CoordinatorReconfiguredNotification(CoordinatorSessionDTO CoordinatorSessionDTO)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.CoordinatorReconfigured);