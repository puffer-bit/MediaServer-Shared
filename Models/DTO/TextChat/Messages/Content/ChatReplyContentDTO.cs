namespace Shared.Models.DTO.TextChat.Messages.Content;

public class ChatReplyContentDTO
{
    public int MessageId { get; init; }
    
    public ChatContentType Type => ChatContentType.Repost;
}