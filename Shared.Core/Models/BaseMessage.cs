using System.Text.Json.Serialization;
using Shared.Models.Notifications.CoordinatorInfo;
using Shared.Models.Notifications.Heartbeat;
using Shared.Models.Notifications.SessionInfo;
using Shared.Models.Requests.Auth;
using Shared.Models.Requests.Coordinator;
using Shared.Models.Requests.Heartbeat;
using Shared.Models.Requests.SessionActions.ChatSession;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.SessionActions.HybridSession;
using Shared.Models.Requests.WebRTC;
using Shared.Models.Responses;
using Shared.Models.Responses.Auth;
using Shared.Models.Responses.Coordinator;
using Shared.Models.Responses.Heartbeat;
using Shared.Models.Responses.SessionActions.ChatSession;
using Shared.Models.Responses.SessionActions.Generic;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Models.Responses.WebRTC;

namespace Shared.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]

// Notifications

[JsonDerivedType(typeof(CoordinatorUserListUpdatedNotification), typeDiscriminator: nameof(CoordinatorUserListUpdatedNotification))]
[JsonDerivedType(typeof(CoordinatorUserConnectedNotification), typeDiscriminator: nameof(CoordinatorUserConnectedNotification))]
[JsonDerivedType(typeof(CoordinatorUserUpdatedNotification), typeDiscriminator: nameof(CoordinatorUserUpdatedNotification))]
[JsonDerivedType(typeof(CoordinatorUserDisconnectedNotification), typeDiscriminator: nameof(CoordinatorUserDisconnectedNotification))]
[JsonDerivedType(typeof(CoordinatorUserKickedNotification), typeDiscriminator: nameof(CoordinatorUserKickedNotification))]
[JsonDerivedType(typeof(CoordinatorUserBannedNotification), typeDiscriminator: nameof(CoordinatorUserBannedNotification))]
[JsonDerivedType(typeof(CoordinatorReconfiguredNotification), typeDiscriminator: nameof(CoordinatorReconfiguredNotification))]

[JsonDerivedType(typeof(HeartbeatServerClosingNotification), typeDiscriminator: nameof(HeartbeatServerClosingNotification))]
[JsonDerivedType(typeof(HeartbeatServerRestartingNotification), typeDiscriminator: nameof(HeartbeatServerRestartingNotification))]

[JsonDerivedType(typeof(ChatSessionMessageAddedNotification), typeDiscriminator: nameof(ChatSessionMessageAddedNotification))]
[JsonDerivedType(typeof(ChatSessionMessageEditedNotification), typeDiscriminator: nameof(ChatSessionMessageEditedNotification))]
[JsonDerivedType(typeof(ChatSessionMessageDeletedNotification), typeDiscriminator: nameof(ChatSessionMessageDeletedNotification))]
[JsonDerivedType(typeof(ChatSessionUserTypingNotification), typeDiscriminator: nameof(ChatSessionUserTypingNotification))]

[JsonDerivedType(typeof(HybridSessionCreatedNotification), typeDiscriminator: nameof(HybridSessionCreatedNotification))]
[JsonDerivedType(typeof(HybridSessionReconfiguredNotification), typeDiscriminator: nameof(HybridSessionReconfiguredNotification))]
[JsonDerivedType(typeof(HybridSessionDeletedNotification), typeDiscriminator: nameof(HybridSessionDeletedNotification))]
[JsonDerivedType(typeof(ChatSessionCreatedNotification), typeDiscriminator: nameof(ChatSessionCreatedNotification))]
[JsonDerivedType(typeof(ChatSessionReconfiguredNotification), typeDiscriminator: nameof(ChatSessionReconfiguredNotification))]
[JsonDerivedType(typeof(ChatSessionDeletedNotification), typeDiscriminator: nameof(ChatSessionDeletedNotification))]

[JsonDerivedType(typeof(HybridSessionPeerStateChangedNotification), typeDiscriminator: nameof(HybridSessionPeerStateChangedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerApprovedNotification), typeDiscriminator: nameof(HybridSessionPeerApprovedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerRejectedNotification), typeDiscriminator: nameof(HybridSessionPeerRejectedNotification))]
[JsonDerivedType(typeof(HybridSessionSFUNodeChangedNotification), typeDiscriminator: nameof(HybridSessionSFUNodeChangedNotification))]
[JsonDerivedType(typeof(HybridSessionSFUNodeConnectedNotification), typeDiscriminator: nameof(HybridSessionSFUNodeConnectedNotification))]
[JsonDerivedType(typeof(HybridSessionSFUNodeDisconnectedNotification), typeDiscriminator: nameof(HybridSessionSFUNodeDisconnectedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerJoinedNotification), typeDiscriminator: nameof(HybridSessionPeerJoinedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerLeftNotification), typeDiscriminator: nameof(HybridSessionPeerLeftNotification))]
[JsonDerivedType(typeof(HybridSessionPeerKickedNotification), typeDiscriminator: nameof(HybridSessionPeerKickedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerIdleKickedNotification), typeDiscriminator: nameof(HybridSessionPeerIdleKickedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerBannedNotification), typeDiscriminator: nameof(HybridSessionPeerBannedNotification))]
[JsonDerivedType(typeof(HybridSessionPeerMovedOutNotification), typeDiscriminator: nameof(HybridSessionPeerMovedOutNotification))]
[JsonDerivedType(typeof(HybridSessionPeerMovedInNotification), typeDiscriminator: nameof(HybridSessionPeerMovedInNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStartedScreenShareNotification), typeDiscriminator: nameof(HybridSessionPeerStartedScreenShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUpdatedScreenShareNotification), typeDiscriminator: nameof(HybridSessionPeerUpdatedScreenShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStoppedScreenShareNotification), typeDiscriminator: nameof(HybridSessionPeerStoppedScreenShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerMutedScreenShareSoundNotification), typeDiscriminator: nameof(HybridSessionPeerMutedScreenShareSoundNotification))]
[JsonDerivedType(typeof(HybridSessionPeerPausedScreenShareNotification), typeDiscriminator: nameof(HybridSessionPeerPausedScreenShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUnmutedScreenShareSoundNotification), typeDiscriminator: nameof(HybridSessionPeerUnmutedScreenShareSoundNotification))]
[JsonDerivedType(typeof(HybridSessionPeerResumedScreenShareNotification), typeDiscriminator: nameof(HybridSessionPeerResumedScreenShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStartedVideoShareNotification), typeDiscriminator: nameof(HybridSessionPeerStartedVideoShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUpdatedVideoShareNotification), typeDiscriminator: nameof(HybridSessionPeerUpdatedVideoShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStoppedVideoShareNotification), typeDiscriminator: nameof(HybridSessionPeerStoppedVideoShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerPausedVideoShareNotification), typeDiscriminator: nameof(HybridSessionPeerPausedVideoShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerResumedVideoShareNotification), typeDiscriminator: nameof(HybridSessionPeerResumedVideoShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStartedVoiceShareNotification), typeDiscriminator: nameof(HybridSessionPeerStartedVoiceShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUpdatedVoiceShareNotification), typeDiscriminator: nameof(HybridSessionPeerUpdatedVoiceShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerStoppedVoiceShareNotification), typeDiscriminator: nameof(HybridSessionPeerStoppedVoiceShareNotification))]
[JsonDerivedType(typeof(HybridSessionPeerMuteMicrophoneNotification), typeDiscriminator: nameof(HybridSessionPeerMuteMicrophoneNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUnmuteMicrophoneNotification), typeDiscriminator: nameof(HybridSessionPeerUnmuteMicrophoneNotification))]
[JsonDerivedType(typeof(HybridSessionPeerMuteSoundNotification), typeDiscriminator: nameof(HybridSessionPeerMuteSoundNotification))]
[JsonDerivedType(typeof(HybridSessionPeerUnmuteSoundNotification), typeDiscriminator: nameof(HybridSessionPeerUnmuteSoundNotification))]
[JsonDerivedType(typeof(HybridSessionPeerAfkNotification), typeDiscriminator: nameof(HybridSessionPeerAfkNotification))]
[JsonDerivedType(typeof(HybridSessionPeerNotAfkNotification), typeDiscriminator: nameof(HybridSessionPeerNotAfkNotification))]
[JsonDerivedType(typeof(HybridSessionPeerPokedNotification), typeDiscriminator: nameof(HybridSessionPeerPokedNotification))]

// Requests

[JsonDerivedType(typeof(UserAuthRequest), typeDiscriminator: nameof(UserAuthRequest))]

[JsonDerivedType(typeof(CoordinatorInfoRequest), typeDiscriminator: nameof(CoordinatorInfoRequest))]
[JsonDerivedType(typeof(CoordinatorUserInfoRequest), typeDiscriminator: nameof(CoordinatorUserInfoRequest))]
[JsonDerivedType(typeof(CoordinatorChangeUsernameRequest), typeDiscriminator: nameof(CoordinatorChangeUsernameRequest))]

[JsonDerivedType(typeof(HeartbeatPingRequest), typeDiscriminator: nameof(HeartbeatPingRequest))]

[JsonDerivedType(typeof(ChatSessionHistoryRequest), typeDiscriminator: nameof(ChatSessionHistoryRequest))]
[JsonDerivedType(typeof(ChatSessionMessageRequest), typeDiscriminator: nameof(ChatSessionMessageRequest))]
[JsonDerivedType(typeof(DeleteTextMessageRequest), typeDiscriminator: nameof(DeleteTextMessageRequest))]
[JsonDerivedType(typeof(EditTextMessageRequest), typeDiscriminator: nameof(EditTextMessageRequest))]
[JsonDerivedType(typeof(SendTextMessageRequest), typeDiscriminator: nameof(SendTextMessageRequest))]

[JsonDerivedType(typeof(ApproveUserRequest), typeDiscriminator: nameof(ApproveUserRequest))]
[JsonDerivedType(typeof(BanInSessionRequest), typeDiscriminator: nameof(BanInSessionRequest))]
[JsonDerivedType(typeof(CreateSessionRequest), typeDiscriminator: nameof(CreateSessionRequest))]
[JsonDerivedType(typeof(DeleteSessionRequest), typeDiscriminator: nameof(DeleteSessionRequest))]
[JsonDerivedType(typeof(JoinSessionRequest), typeDiscriminator: nameof(JoinSessionRequest))]
[JsonDerivedType(typeof(KickFromSessionRequest), typeDiscriminator: nameof(KickFromSessionRequest))]
[JsonDerivedType(typeof(LeaveSessionRequest), typeDiscriminator: nameof(LeaveSessionRequest))]
[JsonDerivedType(typeof(RejectUserRequest), typeDiscriminator: nameof(RejectUserRequest))]
[JsonDerivedType(typeof(SessionInfoRequest), typeDiscriminator: nameof(SessionInfoRequest))]

[JsonDerivedType(typeof(HybridSessionJoinRequest), typeDiscriminator: nameof(HybridSessionJoinRequest))]
[JsonDerivedType(typeof(HybridSessionConnectTransportRequest), typeDiscriminator: nameof(HybridSessionConnectTransportRequest))]
[JsonDerivedType(typeof(HybridSessionLeaveRequest), typeDiscriminator: nameof(HybridSessionLeaveRequest))]
[JsonDerivedType(typeof(HybridSessionPeerListRequest), typeDiscriminator: nameof(HybridSessionPeerListRequest))]
[JsonDerivedType(typeof(HybridSessionStartVideoRequest), typeDiscriminator: nameof(HybridSessionStartVideoRequest))]
[JsonDerivedType(typeof(HybridSessionStopVideoRequest), typeDiscriminator: nameof(HybridSessionStopVideoRequest))]
[JsonDerivedType(typeof(HybridSessionStartScreenShareRequest), typeDiscriminator: nameof(HybridSessionStartScreenShareRequest))]
[JsonDerivedType(typeof(HybridSessionStopScreenShareRequest), typeDiscriminator: nameof(HybridSessionStopScreenShareRequest))]
[JsonDerivedType(typeof(HybridSessionStartVoiceRequest), typeDiscriminator: nameof(HybridSessionStartVoiceRequest))]
[JsonDerivedType(typeof(HybridSessionStopVoiceRequest), typeDiscriminator: nameof(HybridSessionStopVoiceRequest))]
[JsonDerivedType(typeof(HybridSessionSetMicrophoneMuteRequest), typeDiscriminator: nameof(HybridSessionSetMicrophoneMuteRequest))]

[JsonDerivedType(typeof(WebRtcConnectRequest), typeDiscriminator: nameof(WebRtcConnectRequest))]

// Responses

[JsonDerivedType(typeof(UserAuthResponse), typeDiscriminator: nameof(UserAuthResponse))]

[JsonDerivedType(typeof(CoordinatorInfoResponse), typeDiscriminator: nameof(CoordinatorInfoResponse))]
[JsonDerivedType(typeof(CoordinatorUserInfoResponse), typeDiscriminator: nameof(CoordinatorUserInfoResponse))]
[JsonDerivedType(typeof(CoordinatorChangeUsernameResponse), typeDiscriminator: nameof(CoordinatorChangeUsernameResponse))]

[JsonDerivedType(typeof(HeartbeatPingResponse), typeDiscriminator: nameof(HeartbeatPingResponse))]

[JsonDerivedType(typeof(ChatSessionHistoryResponse), typeDiscriminator: nameof(ChatSessionHistoryResponse))]
[JsonDerivedType(typeof(ChatSessionMessageResponse), typeDiscriminator: nameof(ChatSessionMessageResponse))]
[JsonDerivedType(typeof(DeleteTextMessageResponse), typeDiscriminator: nameof(DeleteTextMessageResponse))]
[JsonDerivedType(typeof(EditMessageResponse), typeDiscriminator: nameof(EditMessageResponse))]
[JsonDerivedType(typeof(SendTextMessageResponse), typeDiscriminator: nameof(SendTextMessageResponse))]

[JsonDerivedType(typeof(ApproveUserResponse), typeDiscriminator: nameof(ApproveUserResponse))]
[JsonDerivedType(typeof(BanInSessionResponse), typeDiscriminator: nameof(BanInSessionResponse))]
[JsonDerivedType(typeof(CreateSessionResponse), typeDiscriminator: nameof(CreateSessionResponse))]
[JsonDerivedType(typeof(DeleteSessionResponse), typeDiscriminator: nameof(DeleteSessionResponse))]
[JsonDerivedType(typeof(JoinSessionResponse), typeDiscriminator: nameof(JoinSessionResponse))]
[JsonDerivedType(typeof(KickFromSessionResponse), typeDiscriminator: nameof(KickFromSessionResponse))]
[JsonDerivedType(typeof(LeaveSessionResponse), typeDiscriminator: nameof(LeaveSessionResponse))]
[JsonDerivedType(typeof(RejectUserResponse), typeDiscriminator: nameof(RejectUserResponse))]
[JsonDerivedType(typeof(SessionInfoResponse), typeDiscriminator: nameof(SessionInfoResponse))]

[JsonDerivedType(typeof(HybridSessionJoinResponse), typeDiscriminator: nameof(HybridSessionJoinResponse))]
[JsonDerivedType(typeof(HybridSessionConnectTransportResponse), typeDiscriminator: nameof(HybridSessionConnectTransportResponse))]
[JsonDerivedType(typeof(HybridSessionLeaveResponse), typeDiscriminator: nameof(HybridSessionLeaveResponse))]
[JsonDerivedType(typeof(HybridSessionPeerListResponse), typeDiscriminator: nameof(HybridSessionPeerListResponse))]
[JsonDerivedType(typeof(HybridSessionStartVideoResponse), typeDiscriminator: nameof(HybridSessionStartVideoResponse))]
[JsonDerivedType(typeof(HybridSessionStopVideoResponse), typeDiscriminator: nameof(HybridSessionStopVideoResponse))]
[JsonDerivedType(typeof(HybridSessionStartScreenShareResponse), typeDiscriminator: nameof(HybridSessionStartScreenShareResponse))]
[JsonDerivedType(typeof(HybridSessionStopScreenShareResponse), typeDiscriminator: nameof(HybridSessionStopScreenShareResponse))]
[JsonDerivedType(typeof(HybridSessionStartVoiceResponse), typeDiscriminator: nameof(HybridSessionStartVoiceResponse))]
[JsonDerivedType(typeof(HybridSessionStopVoiceResponse), typeDiscriminator: nameof(HybridSessionStopVoiceResponse))]
[JsonDerivedType(typeof(HybridSessionSetMicrophoneMuteResponse), typeDiscriminator: nameof(HybridSessionSetMicrophoneMuteResponse))]

[JsonDerivedType(typeof(WebRtcConnectResponse), typeDiscriminator: nameof(WebRtcConnectResponse))]

[JsonDerivedType(typeof(RequestRejectedResponse), typeDiscriminator: nameof(RequestRejectedResponse))]
public abstract record BaseMessage
{
    /// <summary>
    /// The authenticated sender, stamped by the server gateway on incoming messages. Not named
    /// UserId: a positional UserId parameter of a derived record would bind to this property
    /// instead of declaring its own, and its value would be silently dropped.
    /// </summary>
    public int SenderId { get; set; }
}
