namespace Shared.Enums
{
    public enum SessionRequestType
    {
        Undefined = 0,
        Create = 1,
        Delete = 2,
        Join = 3,
        Leave = 4,
        HostStateChanged = 6,
        Reconfigure = 8,
        Kick,
        Ban,
        Approve,
        Reject
    }
}

