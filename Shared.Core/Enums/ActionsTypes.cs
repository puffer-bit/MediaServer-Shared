namespace Shared.Enums;

public enum HeartbeatActionType
{
    Ping = 1,
    Pong = 2,
    Disconnected = 3,
    Kicked = 4,
    Banned = 5,
    DisconnectedDueTimeOut = 6,
    DisconnectedDueError = 7,
    ServerRestarting = 8,
    ServerClosing = 9,
}

public enum SessionActionType
{
    Undefined = 0,
    CreateRequest = 1,
    DeleteRequest = 2,
    JoinRequest = 3,
    LeaveRequest = 4,
    ReconfigureRequest = 8,
    KickRequest,
    BanRequest,
    ApproveRequest,
    RejectRequest,
    InfoRequest
}

public enum ChatSessionActionType
{
    SendMessage = 1,
    EditMessage = 2,
    DeleteMessage = 3,
    ChatHistory,
    MessageRequest
}

public enum HybridSessionActionType
{
    Join = 1,
    Leave = 2,
    Rejoin = 3,
    KickPeer = 10,
    BanPeer = 11,
    MovePeer = 12,
    PokePeer = 13,
    ApprovePeer = 14,
    RejectPeer = 15,
    StartScreenShare = 20,
    StopScreenShare = 21,
    PauseScreenShare = 22,
    ResumeScreenShare = 23,
    MuteScreenShareSound = 24,
    UnmuteScreenShareSound = 25,
    StartVideoShare = 30,
    StopVideoShare = 31,
    PauseVideoShare = 32,
    ResumeVideoShare = 33,
    StartVoiceShare = 40,
    StopVoiceShare = 41,
    ToggleMicrophoneMute = 42,
    ToggleSoundMute = 43,
    SetAfkStatus = 50,
    ChangeRoom = 51,
    
    PeerListRequest = 52,
}

public enum WebRtcActionType
{
    Offer = 0,
    Answer = 1,
    ICE = 2,
    Renegotiation = 4
}

public enum CoordinatorActionType
{
    InfoRequest,
    UserInfoRequest,
    ReconfigureRequest,
    DeleteUserRequest,
    BanUserRequest,
    KickUseRequest,
    SuspendUserRequest,
    PurgeUserRequest
}

public enum AuthActionType
{
    Login,
    Logout,
    TwoFactorLogin,
    TwoFactorRegister,
    TwoFactorRevoke,
    TwoFactorChange,
}