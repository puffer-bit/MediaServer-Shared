
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models
{
    public class UserDTO
    {
        public string? Id { get; set; }
        public required string Name { get; set; }
        public string? NickName { get; set; }
        public UserState State { get; set; }

        public UserDTO()
        {
            
        }

        [SetsRequiredMembers]
        public UserDTO (string id, string name, string nickName)
        {
            Id = id;
            Name = name;
            NickName = nickName;
        }

        [SetsRequiredMembers]
        public UserDTO(string name, string nickName)
        {
            Name = name;
            NickName = nickName;
        }
        
        [SetsRequiredMembers]
        public UserDTO(string name)
        {
            Name = name;
        }
    }
}
