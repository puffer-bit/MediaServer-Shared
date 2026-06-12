using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record VideoSessionUpdatedNotification(VideoSessionStateChangedType NotificationType): Notification;

public record VideoSessionParticipantJoinedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserJoined);

public record VideoSessionParticipantConnectedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserConnected);
    
public record VideoSessionParticipantLeavedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserLeaved);

public record VideoSessionParticipantDisconnectedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserDisconnected);

public record VideoSessionParticipantKickedNotification(int SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserKicked);

public record VideoSessionParticipantBannedNotification(int SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserBanned);

public record VideoSessionParticipantApprovedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserApproved);

public record VideoSessionParticipantRejectedNotification(int SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.UserRejected);

public record VideoSessionHostJoinedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostJoined);

public record VideoSessionHostConnectedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostConnected);
    
public record VideoSessionHostLeavedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostLeaved);

public record VideoSessionHostDisconnectedNotification(int SessionId, PeerDTO Peer)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostDisconnected);

public record VideoSessionHostKickedNotification(int SessionId, PeerDTO Peer, string? Reason)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.HostKicked);

public record VideoSessionAnswerReadyNotification(int SessionId, int UserId, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.AnswerReady);

public record VideoSessionIceReadyNotification(int SessionId, int UserId, object Data)
    : VideoSessionUpdatedNotification(VideoSessionStateChangedType.IceReady);

