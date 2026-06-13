using System.Text.Json.Serialization;
using Shared.Models.Notifications.CoordinatorInfo;
using Shared.Models.Notifications.Heartbeat;
using Shared.Models.Notifications.SessionInfo;
using Shared.Models.Requests.Auth;
using Shared.Models.Requests.Coordinator;
using Shared.Models.Requests.Heartbeat;
using Shared.Models.Requests.SessionActions.ChatSession;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.WebRTCNegotiation;
using Shared.Models.Responses.Auth;
using Shared.Models.Responses.Coordinator;
using Shared.Models.Responses.Heartbeat;
using Shared.Models.Responses.SessionActions.ChatSession;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.WebRTCNegotiation;

namespace Shared.Models
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]

    // Notifications
    
    [JsonDerivedType(typeof(CoordinatorUserListUpdatedNotification), typeDiscriminator: "CoordinatorUserListUpdatedNotification")]
    [JsonDerivedType(typeof(CoordinatorUserConnectedNotification), typeDiscriminator: "CoordinatorUserConnectedNotification")]
    [JsonDerivedType(typeof(CoordinatorUserDisconnectedNotification), typeDiscriminator: "CoordinatorUserDisconnectedNotification")]
    [JsonDerivedType(typeof(CoordinatorUserKickedNotification), typeDiscriminator: "CoordinatorUserKickedNotification")]
    [JsonDerivedType(typeof(CoordinatorUserBannedNotification), typeDiscriminator: "CoordinatorUserBannedNotification")]
    [JsonDerivedType(typeof(CoordinatorReconfiguredNotification), typeDiscriminator: "CoordinatorReconfiguredNotification")]
    
    [JsonDerivedType(typeof(HeartbeatServerClosingNotification), typeDiscriminator: "HeartbeatServerClosingNotification")]
    [JsonDerivedType(typeof(HeartbeatServerRestartingNotification), typeDiscriminator: "HeartbeatServerRestartingNotification")]

    [JsonDerivedType(typeof(ChatSessionMessageAddedNotification), typeDiscriminator: "ChatSessionMessageAddedNotification")]
    [JsonDerivedType(typeof(ChatSessionMessageEditedNotification), typeDiscriminator: "ChatSessionMessageEditedNotification")]
    [JsonDerivedType(typeof(ChatSessionMessageDeletedNotification), typeDiscriminator: "ChatSessionMessageDeletedNotification")]
    [JsonDerivedType(typeof(ChatSessionUserTypingNotification), typeDiscriminator: "ChatSessionUserTypingNotification")]

    [JsonDerivedType(typeof(HybridSessionCreatedNotification), typeDiscriminator: "HybridSessionCreatedNotification")]
    [JsonDerivedType(typeof(HybridSessionReconfiguredNotification), typeDiscriminator: "HybridSessionReconfiguredNotification")]
    [JsonDerivedType(typeof(HybridSessionDeletedNotification), typeDiscriminator: "HybridSessionDeletedNotification")]
    [JsonDerivedType(typeof(ChatSessionCreatedNotification), typeDiscriminator: "ChatSessionCreatedNotification")]
    [JsonDerivedType(typeof(ChatSessionReconfiguredNotification), typeDiscriminator: "ChatSessionReconfiguredNotification")]
    [JsonDerivedType(typeof(ChatSessionDeletedNotification), typeDiscriminator: "ChatSessionDeletedNotification")]

    [JsonDerivedType(typeof(HybridSessionPeerConnectedNotification), typeDiscriminator: "VideoSessionPeerConnectedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerDisconnectedNotification), typeDiscriminator: "VideoSessionPeerDisconnectedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerJoinedNotification), typeDiscriminator: "VideoSessionPeerJoinedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerLeftNotification), typeDiscriminator: "VideoSessionPeerLeftNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerKickedNotification), typeDiscriminator: "VideoSessionPeerKickedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerIdleKickedNotification), typeDiscriminator: "VideoSessionPeerIdleKickedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerBannedNotification), typeDiscriminator: "VideoSessionPeerBannedNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerMovedOutNotification), typeDiscriminator: "VideoSessionPeerMovedOutNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerMovedInNotification), typeDiscriminator: "VideoSessionPeerMovedInNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStartedScreenShareNotification), typeDiscriminator: "VideoSessionPeerStartedScreenShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUpdatedScreenShareNotification), typeDiscriminator: "VideoSessionPeerUpdatedScreenShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStoppedScreenShareNotification), typeDiscriminator: "VideoSessionPeerStoppedScreenShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerMutedScreenShareSoundNotification), typeDiscriminator: "VideoSessionPeerMutedScreenShareSoundNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerPausedScreenShareNotification), typeDiscriminator: "VideoSessionPeerPausedScreenShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUnmutedScreenShareSoundNotification), typeDiscriminator: "VideoSessionPeerUnmutedScreenShareSoundNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerResumedScreenShareNotification), typeDiscriminator: "VideoSessionPeerResumedScreenShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStartedHybridShareNotification), typeDiscriminator: "VideoSessionPeerStartedVideoShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUpdatedHybridShareNotification), typeDiscriminator: "VideoSessionPeerUpdatedVideoShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStoppedHybridShareNotification), typeDiscriminator: "VideoSessionPeerStoppedVideoShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerPausedHybridShareNotification), typeDiscriminator: "VideoSessionPeerPausedVideoShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerResumedHybridShareNotification), typeDiscriminator: "VideoSessionPeerResumedVideoShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStartedVoiceShareNotification), typeDiscriminator: "VideoSessionPeerStartedVoiceShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUpdatedVoiceShareNotification), typeDiscriminator: "VideoSessionPeerUpdatedVoiceShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerStoppedVoiceShareNotification), typeDiscriminator: "VideoSessionPeerStoppedVoiceShareNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerMuteMicrophoneNotification), typeDiscriminator: "VideoSessionPeerMuteMicrophoneNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUnmuteMicrophoneNotification), typeDiscriminator: "VideoSessionPeerUnmuteMicrophoneNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerMuteSoundNotification), typeDiscriminator: "VideoSessionPeerMuteSoundNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerUnmuteSoundNotification), typeDiscriminator: "VideoSessionPeerUnmuteSoundNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerAfkNotification), typeDiscriminator: "VideoSessionPeerAfkNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerNotAfkNotification), typeDiscriminator: "VideoSessionPeerNotAfkNotification")]
    [JsonDerivedType(typeof(HybridSessionPeerPokedNotification), typeDiscriminator: "VideoSessionPeerPokedNotification")]

    // Requests
    
    [JsonDerivedType(typeof(UserAuthRequest), typeDiscriminator: "UserAuthRequest")]

    [JsonDerivedType(typeof(CoordinatorInfoRequest), typeDiscriminator: "CoordinatorInfoRequest")]
    [JsonDerivedType(typeof(CoordinatorUserInfoRequest), typeDiscriminator: "CoordinatorUserInfoRequest")]

    [JsonDerivedType(typeof(HeartbeatPingRequest), typeDiscriminator: "HeartbeatPingRequest")]

    [JsonDerivedType(typeof(ChatSessionHistoryRequest), typeDiscriminator: "ChatSessionHistoryRequest")]
    [JsonDerivedType(typeof(ChatSessionMessageRequest), typeDiscriminator: "ChatSessionMessageRequest")]
    [JsonDerivedType(typeof(DeleteTextMessageRequest), typeDiscriminator: "DeleteTextMessageRequest")]
    [JsonDerivedType(typeof(EditTextMessageRequest), typeDiscriminator: "EditTextMessageRequest")]
    [JsonDerivedType(typeof(SendTextMessageRequest), typeDiscriminator: "SendTextMessageRequest")]

    [JsonDerivedType(typeof(ApproveUserRequest), typeDiscriminator: "ApproveUserRequest")]
    [JsonDerivedType(typeof(BanInSessionRequest), typeDiscriminator: "BanInSessionRequest")]
    [JsonDerivedType(typeof(CreateSessionRequest), typeDiscriminator: "CreateSessionRequest")]
    [JsonDerivedType(typeof(DeleteSessionRequest), typeDiscriminator: "DeleteSessionRequest")]
    [JsonDerivedType(typeof(JoinSessionRequest), typeDiscriminator: "JoinSessionRequest")]
    [JsonDerivedType(typeof(KickFromSessionRequest), typeDiscriminator: "KickFromSessionRequest")]
    [JsonDerivedType(typeof(LeaveSessionRequest), typeDiscriminator: "LeaveSessionRequest")]
    [JsonDerivedType(typeof(RejectUserRequest), typeDiscriminator: "RejectUserRequest")]
    [JsonDerivedType(typeof(SessionInfoRequest), typeDiscriminator: "SessionInfoRequest")] 

    [JsonDerivedType(typeof(WebRtcNegotiationRequest), typeDiscriminator: "WebRtcNegotiationRequest")]
    
    // Responses
    
    [JsonDerivedType(typeof(UserAuthResponse), typeDiscriminator: "UserAuth")]

    [JsonDerivedType(typeof(CoordinatorInfoResponse), typeDiscriminator: "CoordinatorInfo")]
    [JsonDerivedType(typeof(CoordinatorUserInfoResponse), typeDiscriminator: "CoordinatorUserInfo")]

    [JsonDerivedType(typeof(HeartbeatPingResponse), typeDiscriminator: "HeartbeatPing")]

    [JsonDerivedType(typeof(ChatSessionHistoryResponse), typeDiscriminator: "ChatSessionHistory")]
    [JsonDerivedType(typeof(ChatSessionMessageResponse), typeDiscriminator: "ChatSessionMessage")]
    [JsonDerivedType(typeof(DeleteTextMessageResponse), typeDiscriminator: "DeleteTextMessage")]
    [JsonDerivedType(typeof(EditMessageResponse), typeDiscriminator: "EditMessage")]
    [JsonDerivedType(typeof(SendTextMessageResponse), typeDiscriminator: "SendTextMessage")]

    [JsonDerivedType(typeof(ApproveUserResponse), typeDiscriminator: "ApproveUser")]
    [JsonDerivedType(typeof(BanInSessionResponse), typeDiscriminator: "BanInSession")]
    [JsonDerivedType(typeof(CreateSessionResponse), typeDiscriminator: "CreateSession")]
    [JsonDerivedType(typeof(DeleteSessionResponse), typeDiscriminator: "DeleteSession")]
    [JsonDerivedType(typeof(JoinSessionResponse), typeDiscriminator: "JoinSession")]
    [JsonDerivedType(typeof(KickFromSessionResponse), typeDiscriminator: "KickFromSession")]
    [JsonDerivedType(typeof(LeaveSessionResponse), typeDiscriminator: "LeaveSession")]
    [JsonDerivedType(typeof(RejectUserResponse), typeDiscriminator: "RejectUser")]
    [JsonDerivedType(typeof(SessionInfoResponse), typeDiscriminator: "SessionInfo")]

    [JsonDerivedType(typeof(WebRtcNegotiationResponse), typeDiscriminator: "WebRtcNegotiation")]
    public abstract record BaseMessage
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        
        public int UserId { get; set; }
    }
}
