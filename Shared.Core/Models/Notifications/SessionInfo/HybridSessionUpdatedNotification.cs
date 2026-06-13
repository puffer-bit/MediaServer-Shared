using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record HybridSessionUpdatedNotification(VideoSessionStateChangedType Type) 
    : Notification;

public record HybridSessionPeerConnectedNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerConnected);

public record HybridSessionPeerDisconnectedNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerDisconnected);

public record HybridSessionPeerJoinedNotification(int SessionId, PeerDTO Peer)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerJoined);

public record HybridSessionPeerLeftNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerLeft);

public record HybridSessionPeerKickedNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerKicked);

public record HybridSessionPeerIdleKickedNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerKickedIdle);

public record HybridSessionPeerBannedNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerBanned);

public record HybridSessionPeerApprovedNotification(int SessionId, int PeerId, int InitiatorPeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerApproved);

public record HybridSessionPeerRejectedNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerRejected);

public record HybridSessionPeerMovedOutNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMovedOut);

public record HybridSessionPeerMovedInNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMovedIn);


public record HybridSessionPeerStartedScreenShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedScreenShare);

public record HybridSessionPeerUpdatedScreenShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedScreenShare);

public record HybridSessionPeerStoppedScreenShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedScreenShare);

public record HybridSessionPeerMutedScreenShareSoundNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMutedScreenShareSound);

public record HybridSessionPeerPausedScreenShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPausedScreenShare);

public record HybridSessionPeerUnmutedScreenShareSoundNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedScreenShareSound);

public record HybridSessionPeerResumedScreenShareNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedScreenShare);


public record HybridSessionPeerStartedHybridShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedVideoShare);

public record HybridSessionPeerUpdatedHybridShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedVideoShare);

public record HybridSessionPeerStoppedHybridShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedVideoShare);

public record HybridSessionPeerPausedHybridShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPausedVideoShare);

public record HybridSessionPeerResumedHybridShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerResumedVideoShare);


public record HybridSessionPeerStartedVoiceShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStartedVoiceShare);

public record HybridSessionPeerUpdatedVoiceShareNotification(int SessionId, int PeerId, Inbound inbound)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUpdatedVoiceShare);

public record HybridSessionPeerStoppedVoiceShareNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerStoppedVoiceShare);


public record HybridSessionPeerMuteMicrophoneNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMuteMicrophone);

public record HybridSessionPeerUnmuteMicrophoneNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUnmuteMicrophone);

public record HybridSessionPeerMuteSoundNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerMuteSound);

public record HybridSessionPeerUnmuteSoundNotification(int SessionId, int PeerId, int? InitiatorPeerId = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerUnmuteSound);


public record HybridSessionPeerAfkNotification(int SessionId, int PeerId, string? Reason = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerAfk);

public record HybridSessionPeerNotAfkNotification(int SessionId, int PeerId)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerNotAfk);

public record HybridSessionPeerPokedNotification(int SessionId, int PeerId, int InitiatorPeerId, string? Message = null)
    : HybridSessionUpdatedNotification(VideoSessionStateChangedType.PeerPoked);