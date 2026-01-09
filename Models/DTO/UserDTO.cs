using System;
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Enums.User;

namespace Shared.Models.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string CoordinatorInstanceId { get; set; }
        public string UserIdentity { get; set; }
        public string Username { get; set; }
        public string? Ip { get; set; }
        public string? RegionName { get; set; }
        public string? RegionCode { get; set; }
        public string? DisplayName { get; set; }
        public string? Prefix { get; set; }
        public string? AvatarUrl { get; set; }
        public UserState State { get; set; }
        public UserStatus Status { get; set; }
        public DateTime FirstConnectionTime { get; set; }
        public DateTime LastConnectionTime { get; set; }
    }
}
