namespace Shared.Enums;

public enum HeartbeatType
{
    Ping = 1,
    Pong = 2,
    Disconnected = 3,
    Kicked = 4,
    Banned = 5,
    DisconnectedDueTimeOut = 6,
    DisconnectedDueError = 7
}