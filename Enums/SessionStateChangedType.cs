namespace Shared.Enums;

public enum SessionStateChangedType
{
    UserConnected = 1,
    UserDisconnected = 2,
    UserKicked = 3,
    SessionCreated = 4,
    SessionDeleted = 5,
    SessionReconfigured = 6,
    HostConnected = 7,
    HostDissconnected = 8
}