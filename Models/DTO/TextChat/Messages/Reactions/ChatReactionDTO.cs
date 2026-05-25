namespace Shared.Models.DTO.TextChat.Messages.Reactions;

public class ChatReactionDTO
{
    public int UserId { get; set; }
    public required string Emoji { get; init; } = null!;
}