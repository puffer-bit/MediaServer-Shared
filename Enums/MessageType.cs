namespace Shared.Enums
{
    public enum MessageType
    {
        Undefined = 0,
        WebRTCInit = 2,
        RoomRequest = 6,
        UserAuth = 7,
        SessionsListRequest = 9,
        SessionInfoRequest = 10,
        Heartbeat = 11,
        SessionsStateChanged = 12,
    }
}
