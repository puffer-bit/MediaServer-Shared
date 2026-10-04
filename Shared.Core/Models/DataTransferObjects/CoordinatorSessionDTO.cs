namespace Shared.Models.DataTransferObjects;

public class CoordinatorSessionDTO
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int Port { get; set; }

    public bool IsStunServerAvailable { get; set; }
    public bool IsTurnServerAvailable { get; set; }

    public bool IsTurnEnabled { get; set; }
    public string? TurnAddress { get; set; }
    public ushort? TurnPort { get; set; }
    public string? TurnUsername { get; set; }
    public string? TurnPassword { get; set; }

    public bool IsStunEnabled { get; set; }
    public string? StunAddress { get; set; }
    public ushort? StunPort { get; set; }

    public int ConnectedUsersCount { get; set; }

    public string ServerVersion { get; set; } = string.Empty;

    public DateTime CreateTime { get; set; }
    public DateTime FirstLaunchTime { get; set; }
    public DateTime CurrentLaunchTime { get; set; }
    public int MaxOnlineUsers { get; set; }
    public int MaxUsers { get; set; }

    public bool IsMOTDEnabled { get; set; }
}
