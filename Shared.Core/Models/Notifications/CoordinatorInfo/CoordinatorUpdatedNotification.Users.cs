using Shared.Models.DataTransferObjects;

namespace Shared.Models.Notifications.CoordinatorInfo;

public record CoordinatorUserListUpdatedNotification(IList<UserDTO> Users)
    : CoordinatorUpdatedNotification;

public record CoordinatorUserConnectedNotification(UserDTO User)
    : CoordinatorUpdatedNotification;

public record CoordinatorUserUpdatedNotification(UserDTO User)
    : CoordinatorUpdatedNotification;

public record CoordinatorUserDisconnectedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification;

public record CoordinatorUserKickedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification;

public record CoordinatorUserBannedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification;
