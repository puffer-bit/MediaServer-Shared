using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Media;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record HybridSessionUpdatedNotification(HybridSessionStateChangedType Type) 
    : Notification;

public record HybridSessionSFUNodeChangedNotification(int SessionId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.SFUNodeChanged);

public record HybridSessionSFUNodeDisconnectedNotification(int SessionId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.SFUNodeDisconnected);

public record HybridSessionSFUNodeConnectedNotification(int SessionId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.SFUNodeConnected);

public record HybridSessionPeerStateChangedNotification(int SessionId, int UserId, HybridSessionPeerState State)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStateChanged);

public record HybridSessionPeerJoinedNotification(int SessionId, PeerDTO Peer)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerJoined);

public record HybridSessionPeerLeftNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerLeft);

public record HybridSessionPeerKickedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerKicked);

public record HybridSessionPeerIdleKickedNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerKickedIdle);

public record HybridSessionPeerBannedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerBanned);

public record HybridSessionPeerApprovedNotification(int SessionId, int UserId, int InitiatorUserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerApproved);

public record HybridSessionPeerRejectedNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerRejected);

public record HybridSessionPeerMovedOutNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerMovedOut);

public record HybridSessionPeerMovedInNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerMovedIn);


public record HybridSessionPeerStartedScreenShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStartedScreenShare);

public record HybridSessionPeerUpdatedScreenShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUpdatedScreenShare);

public record HybridSessionPeerStoppedScreenShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStoppedScreenShare);

public record HybridSessionPeerMutedScreenShareSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerMutedScreenShareSound);

public record HybridSessionPeerPausedScreenShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerPausedScreenShare);

public record HybridSessionPeerUnmutedScreenShareSoundNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUnmutedScreenShareSound);

public record HybridSessionPeerResumedScreenShareNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerResumedScreenShare);


public record HybridSessionPeerStartedVideoShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStartedVideoShare);

public record HybridSessionPeerUpdatedVideoShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUpdatedVideoShare);

public record HybridSessionPeerStoppedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStoppedVideoShare);

public record HybridSessionPeerPausedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerPausedVideoShare);

public record HybridSessionPeerResumedVideoShareNotification(int SessionId, int UserId, int? InitiatorUserId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerResumedVideoShare);


public record HybridSessionPeerStartedVoiceShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStartedVoiceShare);

public record HybridSessionPeerUpdatedVoiceShareNotification(int SessionId, int UserId, Inbound Inbound)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUpdatedVoiceShare);

public record HybridSessionPeerStoppedVoiceShareNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerStoppedVoiceShare);

public record HybridSessionPeerMuteMicrophoneNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerMuteMicrophone);

public record HybridSessionPeerUnmuteMicrophoneNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUnmuteMicrophone);

public record HybridSessionPeerMuteSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerMuteSound);

public record HybridSessionPeerUnmuteSoundNotification(int SessionId, int UserId, int? InitiatorUserId = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerUnmuteSound);


public record HybridSessionPeerAfkNotification(int SessionId, int UserId, string? Reason = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerAfk);

public record HybridSessionPeerNotAfkNotification(int SessionId, int UserId)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerNotAfk);

public record HybridSessionPeerPokedNotification(int SessionId, int UserId, int InitiatorUserId, string? Message = null)
    : HybridSessionUpdatedNotification(HybridSessionStateChangedType.PeerPoked);