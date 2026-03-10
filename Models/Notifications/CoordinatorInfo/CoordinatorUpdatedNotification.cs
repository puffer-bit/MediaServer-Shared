using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Notifications.SessionInfo;

namespace Shared.Models.Notifications.CoordinatorInfo;

public abstract record CoordinatorUpdatedNotification(CoordinatorStateChangedType Type);

public record CoordinatorUserListUpdatedNotification(IList<UserDTO> Users)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UsersListUpdated);

public record CoordinatorUserConnectedNotification(UserDTO User)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserConnected);

public record CoordinatorUserDisconnectedNotification(UserDTO User, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserDisconnected);

public record CoordinatorUserKickedNotification(UserDTO User, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserKicked);

public record CoordinatorUserBannedNotification(UserDTO User, string? Reason = null)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.UserBanned);

public record CoordinatorReconfiguredNotification(CoordinatorSessionDTO CoordinatorSessionDTO)
    : CoordinatorUpdatedNotification(CoordinatorStateChangedType.CoordinatorReconfigured);