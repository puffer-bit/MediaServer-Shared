using System.Text.Json.Serialization;
using Shared.Enums;
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

    [JsonDerivedType(typeof(SessionCreatedNotification), typeDiscriminator: "SessionCreatedNotification")]
    [JsonDerivedType(typeof(SessionReconfiguredNotification), typeDiscriminator: "SessionReconfiguredNotification")]
    [JsonDerivedType(typeof(SessionDeletedNotification), typeDiscriminator: "SessionDeletedNotification")]

    [JsonDerivedType(typeof(VideoSessionParticipantJoinedNotification), typeDiscriminator: "VideoSessionParticipantJoinedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantConnectedNotification), typeDiscriminator: "VideoSessionParticipantConnectedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantLeavedNotification), typeDiscriminator: "VideoSessionParticipantLeavedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantDisconnectedNotification), typeDiscriminator: "VideoSessionParticipantDisconnectedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantKickedNotification), typeDiscriminator: "VideoSessionParticipantKickedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantBannedNotification), typeDiscriminator: "VideoSessionParticipantBannedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantApprovedNotification), typeDiscriminator: "VideoSessionParticipantApprovedNotification")]
    [JsonDerivedType(typeof(VideoSessionParticipantRejectedNotification), typeDiscriminator: "VideoSessionParticipantRejectedNotification")]
    [JsonDerivedType(typeof(VideoSessionHostJoinedNotification), typeDiscriminator: "VideoSessionHostJoinedNotification")]
    [JsonDerivedType(typeof(VideoSessionHostConnectedNotification), typeDiscriminator: "VideoSessionHostConnectedNotification")]
    [JsonDerivedType(typeof(VideoSessionHostLeavedNotification), typeDiscriminator: "VideoSessionHostLeavedNotification")]
    [JsonDerivedType(typeof(VideoSessionHostDisconnectedNotification), typeDiscriminator: "VideoSessionHostDisconnectedNotification")]
    [JsonDerivedType(typeof(VideoSessionHostKickedNotification), typeDiscriminator: "VideoSessionHostKickedNotification")]
    [JsonDerivedType(typeof(VideoSessionAnswerReadyNotification), typeDiscriminator: "VideoSessionAnswerReadyNotification")]
    [JsonDerivedType(typeof(VideoSessionIceReadyNotification), typeDiscriminator: "VideoSessionIceReadyNotification")]

    // Requests

    [JsonDerivedType(typeof(AuthRequest), typeDiscriminator: "AuthRequest")]
    [JsonDerivedType(typeof(UserAuthRequest), typeDiscriminator: "UserAuthRequest")]

    [JsonDerivedType(typeof(CoordinatorRequest), typeDiscriminator: "CoordinatorRequest")]
    [JsonDerivedType(typeof(CoordinatorInfoRequest), typeDiscriminator: "CoordinatorInfoRequest")]
    [JsonDerivedType(typeof(CoordinatorUserInfoRequest), typeDiscriminator: "CoordinatorUserInfoRequest")]

    [JsonDerivedType(typeof(HeartbeatRequest), typeDiscriminator: "HeartbeatRequest")]
    [JsonDerivedType(typeof(HeartbeatPingRequest), typeDiscriminator: "HeartbeatPingRequest")]

    [JsonDerivedType(typeof(ChatSessionRequest), typeDiscriminator: "ChatSessionRequest")]
    [JsonDerivedType(typeof(ChatSessionHistoryRequest), typeDiscriminator: "ChatSessionHistoryRequest")]
    [JsonDerivedType(typeof(ChatSessionMessageRequest), typeDiscriminator: "ChatSessionMessageRequest")]
    [JsonDerivedType(typeof(DeleteTextMessageRequest), typeDiscriminator: "DeleteTextMessageRequest")]
    [JsonDerivedType(typeof(EditTextMessageRequest), typeDiscriminator: "EditTextMessageRequest")]
    [JsonDerivedType(typeof(SendTextMessageRequest), typeDiscriminator: "SendTextMessageRequest")]

    [JsonDerivedType(typeof(GenericSessionRequest), typeDiscriminator: "GenericSessionRequest")]
    [JsonDerivedType(typeof(ApproveUserRequest), typeDiscriminator: "ApproveUserRequest")]
    [JsonDerivedType(typeof(BanInSessionRequest), typeDiscriminator: "BanInSessionRequest")]
    [JsonDerivedType(typeof(CreateSessionRequest), typeDiscriminator: "CreateSessionRequest")]
    [JsonDerivedType(typeof(DeleteSessionRequest), typeDiscriminator: "DeleteSessionRequest")]
    [JsonDerivedType(typeof(JoinSessionRequest), typeDiscriminator: "JoinSessionRequest")]
    [JsonDerivedType(typeof(KickFromSessionRequest), typeDiscriminator: "KickFromSessionRequest")]
    [JsonDerivedType(typeof(LeaveSessionRequest), typeDiscriminator: "LeaveSessionRequest")]
    [JsonDerivedType(typeof(RejectUserRequest), typeDiscriminator: "RejectUserRequest")]
    [JsonDerivedType(typeof(SessionInfoRequest), typeDiscriminator: "SessionInfoRequest")] 

    [JsonDerivedType(typeof(WebRtcRequest), typeDiscriminator: "WebRtcRequest")]
    [JsonDerivedType(typeof(WebRtcNegotiationRequest), typeDiscriminator: "WebRtcNegotiationRequest")]
    
    // Responses
    
    [JsonDerivedType(typeof(AuthResponse), typeDiscriminator: "Auth")]
    [JsonDerivedType(typeof(UserAuthResponse), typeDiscriminator: "UserAuth")]

    [JsonDerivedType(typeof(CoordinatorResponse), typeDiscriminator: "Coordinator")]
    [JsonDerivedType(typeof(CoordinatorInfoResponse), typeDiscriminator: "CoordinatorInfo")]
    [JsonDerivedType(typeof(CoordinatorUserInfoResponse), typeDiscriminator: "CoordinatorUserInfo")]

    [JsonDerivedType(typeof(HeartbeatResponse), typeDiscriminator: "Heartbeat")]
    [JsonDerivedType(typeof(HeartbeatPingResponse), typeDiscriminator: "HeartbeatPing")]

    [JsonDerivedType(typeof(ChatSessionResponse), typeDiscriminator: "ChatSession")]
    [JsonDerivedType(typeof(ChatSessionHistoryResponse), typeDiscriminator: "ChatSessionHistory")]
    [JsonDerivedType(typeof(ChatSessionMessageResponse), typeDiscriminator: "ChatSessionMessage")]
    [JsonDerivedType(typeof(DeleteTextMessageResponse), typeDiscriminator: "DeleteTextMessage")]
    [JsonDerivedType(typeof(EditMessageResponse), typeDiscriminator: "EditMessage")]
    [JsonDerivedType(typeof(SendTextMessageResponse), typeDiscriminator: "SendTextMessage")]

    [JsonDerivedType(typeof(GenericSessionResponse), typeDiscriminator: "GenericSession")]
    [JsonDerivedType(typeof(ApproveUserResponse), typeDiscriminator: "ApproveUser")]
    [JsonDerivedType(typeof(BanInSessionResponse), typeDiscriminator: "BanInSession")]
    [JsonDerivedType(typeof(CreateSessionResponse), typeDiscriminator: "CreateSession")]
    [JsonDerivedType(typeof(DeleteSessionResponse), typeDiscriminator: "DeleteSession")]
    [JsonDerivedType(typeof(JoinSessionResponse), typeDiscriminator: "JoinSession")]
    [JsonDerivedType(typeof(KickFromSessionResponse), typeDiscriminator: "KickFromSession")]
    [JsonDerivedType(typeof(LeaveSessionResponse), typeDiscriminator: "LeaveSession")]
    [JsonDerivedType(typeof(RejectUserResponse), typeDiscriminator: "RejectUser")]
    [JsonDerivedType(typeof(SessionInfoResponse), typeDiscriminator: "SessionInfo")]

    [JsonDerivedType(typeof(WebRtcResponse), typeDiscriminator: "WebRtc")]
    [JsonDerivedType(typeof(WebRtcNegotiationResponse), typeDiscriminator: "WebRtcNegotiation")]
    public abstract record BaseMessage
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        
        public int UserId { get; set; }
    }
}
