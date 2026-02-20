namespace Shared.Models.DTO.TextChat;

public class ChatRepostContentDTO
{
    public string MessageId { get; init; }
    
    public ChatContentType Type => ChatContentType.Repost;
}