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