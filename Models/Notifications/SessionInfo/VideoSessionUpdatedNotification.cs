using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record VideoSessionUpdatedNotification(VideoSessionStateChangedType Type);

public record VideoSessionParticipantJoinedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserJoined);

public record VideoSessionParticipantConnectedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserConnected);
    
public record VideoSessionParticipantLeavedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserLeaved);

public record VideoSessionParticipantDisconnectedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserDisconnected);

public record VideoSessionParticipantKickedNotification(string SessionId, UserDTO User, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserKicked);

public record VideoSessionParticipantBannedNotification(string SessionId, UserDTO User, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserBanned);

public record VideoSessionParticipantApprovedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserApproved);

public record VideoSessionParticipantRejectedNotification(string SessionId, UserDTO User, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserRejected);

public record VideoSessionHostJoinedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record VideoSessionHostConnectedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostConnected);
    
public record VideoSessionHostLeavedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record VideoSessionHostDisconnectedNotification(string SessionId, UserDTO User)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostDisconnected);

public record VideoSessionHostKickedNotification(string SessionId, UserDTO User, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);

public record VideoSessionAnswerReadyNotification(string SessionId, string UserId, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);

public record VideoSessionIceReadyNotification(string SessionId, string UserId, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);
