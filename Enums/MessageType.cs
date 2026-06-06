namespace Shared.Enums
{
    public enum MessageType
    {
        Undefined = 0,
        WebRTCAction = 2,
        SessionAction = 6,
        UserAuthAction = 7,
        UserAction = 8,
        SessionInfoRequest = 10,
        HeartbeatAction = 11,
        SessionsStateChanged = 12,
        ChatSessionAction = 13,
        CoordinatorAction
    }
}
