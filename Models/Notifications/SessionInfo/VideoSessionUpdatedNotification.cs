using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record VideoSessionUpdatedNotification(VideoSessionStateChangedType Type);

public record VideoSessionParticipantJoinedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserJoined);

public record VideoSessionParticipantConnectedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserConnected);
    
public record VideoSessionParticipantLeavedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserLeaved);

public record VideoSessionParticipantDisconnectedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserDisconnected);

public record VideoSessionParticipantKickedNotification(string SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserKicked);

public record VideoSessionParticipantBannedNotification(string SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserBanned);

public record VideoSessionParticipantApprovedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserApproved);

public record VideoSessionParticipantRejectedNotification(string SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserRejected);

public record VideoSessionHostJoinedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record VideoSessionHostConnectedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostConnected);
    
public record VideoSessionHostLeavedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record VideoSessionHostDisconnectedNotification(string SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostDisconnected);

public record VideoSessionHostKickedNotification(string SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);

public record VideoSessionAnswerReadyNotification(string SessionId, PeerDTO Peer, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);

public record VideoSessionIceReadyNotification(string SessionId, PeerDTO Peer, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);
