using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Notifications.CoordinatorInfo;

public record CoordinatorUserListUpdatedNotification(IList<UserDTO> Users)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UsersListUpdated);

public record CoordinatorUserConnectedNotification(UserDTO User)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserConnected);

public record CoordinatorUserUpdatedNotification(UserDTO User)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserUpdated);

public record CoordinatorUserDisconnectedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserDisconnected);

public record CoordinatorUserKickedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserKicked);

public record CoordinatorUserBannedNotification(int UserId, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserBanned);
