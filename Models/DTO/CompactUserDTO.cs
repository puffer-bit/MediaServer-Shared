using Shared.Enums.User;

namespace Shared.Models.DTO;

public class CompactUserDTO
{
    public int Id { get; set; }
    public string CoordinatorInstanceId { get; set; }
    public string Username { get; set; }
    public string? DisplayName { get; set; }
    public string? Prefix { get; set; }
    public string? AvatarUrl { get; set; }
    public UserState State { get; set; }
}