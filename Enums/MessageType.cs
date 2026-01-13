namespace Shared.Enums
{
    public enum MessageType
    {
        Undefined = 0,
        WebRTCInit = 2,
        SessionRequest = 6,
        UserAuth = 7,
        UserInfoRequest = 8,
        SessionInfoRequest = 10,
        Heartbeat = 11,
        SessionsStateChanged = 12,
    }
}
