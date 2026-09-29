using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record HybridSessionUpdatedNotification(VideoSessionStateChangedType Type) 
    : Notification;

public record HybridSessionSFUNodeChangedNotification(int SessionId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.SFUNodeChanged);

public record HybridSessionSFUNodeDisconnectedNotification(int SessionId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.SFUNodeDisconnected);

public record HybridSessionSFUNodeConnectedNotification(int SessionId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.SFUNodeConnected);

public record HybridSessionPeerStateChangedNotification(int SessionId, int UserId, HybridSessionPeerState State)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStateChaged);

public record HybridSessionPeerJoinedNotification(int SessionId, PeerDTO Peer)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerJoined);

public record HybridSessionPeerLeftNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerLeft);

public record HybridSessionPeerKickedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerKicked);

public record HybridSessionPeerIdleKickedNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerKickedIdle);

public record HybridSessionPeerBannedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerBanned);

public record HybridSessionPeerApprovedNotification(int SessionId, int UserId, int InitiatorUserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerApproved);

public record HybridSessionPeerRejectedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerRejected);

public record HybridSessionPeerMovedOutNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMovedOut);

public record HybridSessionPeerMovedInNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMovedIn);


public record HybridSessionPeerStartedScreenShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedScreenShare);

public record HybridSessionPeerUpdatedScreenShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedScreenShare);

public record HybridSessionPeerStoppedScreenShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedScreenShare);

public record HybridSessionPeerMutedScreenShareSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMutedScreenShareSound);

public record HybridSessionPeerPausedScreenShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPausedScreenShare);

public record HybridSessionPeerUnmutedScreenShareSoundNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedScreenShareSound);

public record HybridSessionPeerResumedScreenShareNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedScreenShare);


public record HybridSessionPeerStartedVideoShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedVideoShare);

public record HybridSessionPeerUpdatedVideoShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedVideoShare);

public record HybridSessionPeerStoppedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedVideoShare);

public record HybridSessionPeerPausedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPausedVideoShare);

public record HybridSessionPeerResumedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedVideoShare);


public record HybridSessionPeerStartedVoiceShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedVoiceShare);

public record HybridSessionPeerUpdatedVoiceShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedVoiceShare);

public record HybridSessionPeerStoppedVoiceShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedVoiceShare);

public record HybridSessionPeerMuteMicrophoneNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMuteMicrophone);

public record HybridSessionPeerUnmuteMicrophoneNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUnmuteMicrophone);

public record HybridSessionPeerMuteSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMuteSound);

public record HybridSessionPeerUnmuteSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUnmuteSound);


public record HybridSessionPeerAfkNotification(int SessionId, int UserId, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerAfk);

public record HybridSessionPeerNotAfkNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerNotAfk);

public record HybridSessionPeerPokedNotification(int SessionId, int UserId, int InitiatorUserId, string? Message = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPoked);