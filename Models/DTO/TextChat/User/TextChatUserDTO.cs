using System.Diagnostics.CodeAnalysis;

namespace Shared.Models.DTO.TextChat;

public class TextChatUserDTO
{
    public required string UserId { get; init; }
    public bool IsAdmin { get; private set; }

    [SetsRequiredMembers]
    public TextChatUserDTO(string userId)
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