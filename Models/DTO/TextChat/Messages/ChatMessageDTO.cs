namespace Shared.Models.DTO.TextChat;

public class ChatMessageDTO
{
    public required string Id { get; init; }
    public required string ChatId { get; init; }
    public required string SenderUserId { get; init; }
    public required DateTime SentTime { get; init; }
    public DateTime? DelayedSentTime { get; set; }
    public DateTime? DisposeTime { get; set; }
    public DateTime? EditTime { get; set; }

    public required ChatTextContentDTO TextContent { get; set; }
    public required ChatRepostContentDTO RepostContent { get; init; }
    
    public required List<ChatImageContentDTO> Images { get; init; }
    public required List<ChatVideoContentDTO> Video { get; init; }
    public required List<ChatFileContentDTO> Files { get; init; }
    
    public required List<ChatReactionDTO> Reactions { get; init; }
    public required List<string> UsersIds { get; init; }

    public bool IsDelayed { get; set; }
    public bool IsEdited { get; set; }
    public bool IsReposted { get; set; }
    public bool IsDelivered { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsReadOnly { get; set; }
    public bool IsSystem { get; set; }
    public bool IsDisposable { get; set; }
}

public enum ChatContentType
{
    File,
    Text,
    Image,
    Video,
    Repost
}