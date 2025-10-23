namespace Shared.Enums;

public enum SessionStateChangedType
{
    UserConnected = 1,
    UserDisconnected = 2,
    UserKicked = 3,
    UserNegotiated = 4,
    UserBanned = 5,
    UserApproved = 6,
    SessionCreated = 7,
    SessionDeleted = 8,
    SessionReconfigured = 9,
    HostConnected = 10,
    HostDisconnected = 11,
    HostNegotiated = 12,
    UserRejected
}