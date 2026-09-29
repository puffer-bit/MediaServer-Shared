using Shared.Enums.User;

namespace Shared.Models.DataTransferObjects;

public class CompactUserDTO
{
    public int Id { get; set; }
    public string CoordinatorInstanceId { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string? DisplayName { get; set; }
    public string? Prefix { get; set; }
    public string? AvatarUrl { get; set; }
    public UserState State { get; set; }
}