using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.Users;

public class UsersInfoRequestModel
{
    public List<string> RequestedUsersList { get; set; } = new();
    public Dictionary<string, UserDTO?> UsersData { get; set; } = new();
    public required bool IsAllUsersRequested { get; set; }
    public UsersRequestResult Result { get; set; }

    [SetsRequiredMembers]
    public UsersInfoRequestModel(bool isAllUsersRequested)
    {
        IsAllUsersRequested = isAllUsersRequested;
    }

    public void AddRequestedUser(string userId)
    {
        RequestedUsersList.Add(userId);
    }
    
    public void AddUser(string userId, UserDTO? user)
    {
        UsersData.Add(userId, user);
    }

    public void FetchUsersFromDictionary(IDictionary<string, UserDTO> users)
    {
        UsersData.Clear();
        foreach (var user in users)
        {
            UsersData.Add(user.Key, user.Value);
        }
    }
}