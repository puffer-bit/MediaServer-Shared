namespace Shared.Enums;

public enum VideoSessionPeerState
{
    New = 0,
    WaitingForApprove = 1,
    WaitingForNegotiation = 2,
    Connected = 3,
    Closed = 4,
}