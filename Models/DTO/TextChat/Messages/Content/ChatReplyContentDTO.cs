namespace Shared.Models.DTO.TextChat.Messages.Content;

public class ChatReplyContentDTO
{
    public string MessageId { get; init; }
    
    public ChatContentType Type => ChatContentType.Repost;
}