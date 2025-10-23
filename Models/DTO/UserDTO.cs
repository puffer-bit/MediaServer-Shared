using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.DTO
{
    public class UserDTO
    {
        public string? Id { get; set; }
        public string? UserIdentity { get; set; }
        public string? Username { get; set; }
        public string? Ip { get; set; }
        public string? CoordinatorInstanceId { get; set; }
        public string? RegionName { get; set; }
        public string? RegionCode { get; set; }
        public string? DisplayName { get; set; }
        public string? Prefix { get; set; }
        public string? AvatarUrl { get; set; }
        public UserState State { get; set; }
        public DateTime FirstConnectionTime { get; set; }
        public DateTime LastConnectionTime { get; set; }
        public TimeSpan ConnectionTime => DateTime.UtcNow - LastConnectionTime;

        public UserDTO()
        {
            
        }

        [SetsRequiredMembers]
        public UserDTO (string id, string name, string nickName)
        {
            Id = id;
            Username = name;
            DisplayName = nickName;
        }

        [SetsRequiredMembers]
        public UserDTO(string name, string nickName)
        {
            Username = name;
            DisplayName = nickName;
        }
        
        [SetsRequiredMembers]
        public UserDTO(string name)
        {
            Username = name;
        }
    }
}
