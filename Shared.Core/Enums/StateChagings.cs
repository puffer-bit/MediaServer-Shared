namespace Shared.Enums;

public enum CoordinatorStateChangedType
{
    UsersListUpdated = 1,
    CoordinatorReconfigured = 8,
    UserConnected = 9,
    UserDisconnected = 10,
    UserKicked = 11,
    UserBanned
}

public enum SessionsStateChangedType
{
    HybridSessionCreated = 7,
    HybridSessionDeleted = 8,
    HybridSessionReconfigured = 9,
    ChatSessionCreated = 10,
    ChatSessionDeleted = 11,
    ChatSessionReconfigured = 12,
}

public enum VideoSessionStateChangedType
{
    PeerConnected = 1,
    PeerDisconnected,
    PeerKicked,
    PeerKickedIdle,
    PeerBanned,
    PeerJoined,
    PeerApproved,
    PeerRejected,
    PeerLeft,
    PeerStartedScreenShare,
    PeerUpdatedScreenShare,
    PeerStoppedScreenShare,
    PeerMutedScreenShareSound,
    PeerPausedScreenShare,
    PeerResumedScreenShareSound,
    PeerResumedScreenShare,
    PeerStartedVideoShare,
    PeerUpdatedVideoShare,
    PeerStoppedVideoShare,
    PeerPausedVideoShare,
    PeerResumedVideoShare,
    PeerStartedVoiceShare,
    PeerUpdatedVoiceShare,
    PeerStoppedVoiceShare,
    PeerPausedVoiceShare,
    PeerMuteMicrophone,
    PeerUnmuteMicrophone,
    PeerMuteSound,
    PeerUnmuteSound,
    PeerAfk,
    PeerNotAfk,
    PeerPoked,
    PeerMovedOut,
    PeerMovedIn,
}

public enum ChatSessionStateChangedType
{
    UserTyping = 1,
    MessageAdded = 2,
    MessageEdited,
    MessageDeleted
}

public enum HeartbeatStateChangedType
{
    ServerClosing,
    ServerRestarting
}