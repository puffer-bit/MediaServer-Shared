namespace Shared.Enums;

public enum SessionsStateChangedType
{
    SessionCreated = 7,
    SessionDeleted = 8,
    SessionReconfigured = 9
}

public enum SessionStateChangedType
{
    UserConnected = 1,
    UserDisconnected = 2,
    UserKicked = 3,
    UserNegotiated = 4,
    UserBanned = 5,
    UserApproved = 6,
    HostConnected = 10,
    HostDisconnected = 11,
    HostNegotiated = 12,
    UserRejected = 13,
    HostKicked = 14,
    UserJoined,
    UserLeaved,
    HostJoined
}