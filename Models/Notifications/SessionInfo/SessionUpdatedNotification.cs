using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SessionUpdatedNotification(VideoSessionStateChangedType Type);

public record ParticipantJoinedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserJoined);

public record ParticipantConnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserConnected);
    
public record ParticipantLeavedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserLeaved);

public record ParticipantDisconnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserDisconnected);

public record ParticipantKickedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserKicked);

public record ParticipantBannedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserBanned);

public record ParticipantApprovedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserApproved);

public record ParticipantRejectedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.UserRejected);

public record HostJoinedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record HostConnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.HostConnected);
    
public record HostLeavedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record HostDisconnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.HostDisconnected);

public record HostKickedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);
