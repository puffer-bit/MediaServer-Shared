namespace Shared.Models.DataTransferObjects.ChatSession.Messages.Content;

public class ChatReplyContentDTO
{
    public required int MessageId { get; init; }
    public CompactUserDTO SenderUser { get; init; }
    public DateTime SentTime { get; init; }
    public ChatTextContentDTO TextContent { get; init; }
    public int IsDeleted { get; set; }
    public ChatContentType Type => ChatContentType.Reply;
}