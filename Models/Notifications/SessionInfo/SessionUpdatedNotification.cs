using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionInfo;

public abstract record SessionUpdatedNotification(SessionStateChangedType Type);

public record ParticipantJoinedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserJoined);

public record ParticipantConnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserConnected);
    
public record ParticipantLeavedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserLeaved);

public record ParticipantDisconnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserDisconnected);

public record ParticipantKickedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserKicked);

public record ParticipantBannedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserBanned);

public record ParticipantApprovedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserApproved);

public record ParticipantRejectedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.UserRejected);

public record HostJoinedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.HostJoined);

public record HostConnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.HostConnected);
    
public record HostLeavedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.HostJoined);

public record HostDisconnectedNotification(string SessionId, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.HostDisconnected);

public record HostKickedNotification(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedNotification(SessionStateChangedType.HostKicked);
