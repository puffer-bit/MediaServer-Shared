using System.Diagnostics.CodeAnalysis;

namespace Shared.Models.DataTransferObjects.TextChat.User;

public class TextChatUserDTO
{
    public required int UserId { get; init; }
    public bool IsAdmin { get; private set; }

    [SetsRequiredMembers]
    public TextChatUserDTO(int userId)
    {
        UserId = userId;
    }
    
    public void MakeAdmin()
    {
        IsAdmin = true;
    }

    public void RemoveAdmin()
    {
        IsAdmin = false;
    }
}