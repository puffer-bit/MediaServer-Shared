namespace Shared.Models.DataTransferObjects.ChatSession.Messages.Content;

public class ChatReplyContentDTO
{
    public int MessageId { get; init; }
    public bool IsDeleted { get; set; }
    public ChatContentType Type => ChatContentType.Repost;
}