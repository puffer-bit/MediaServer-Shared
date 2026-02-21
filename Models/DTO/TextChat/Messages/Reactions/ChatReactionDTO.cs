namespace Shared.Models.DTO.TextChat.Messages.Reactions;

public class ChatReactionDTO
{
    public string UserId { get; set; } = null!;
    public required string Emoji { get; init; } = null!;
}