namespace Shared.Enums;

public enum VideoSessionApproveState
{
    WaitingForApprove = 0,
    Approved = 1,
    Rejected = 2,
    WaitingForNegotiation = 3,
    Connected = 4,
    Kicked = 5,
    Banned = 6,
}