using Shared.Models.DTO.TextChat.Messages.Content;
using Shared.Models.DTO.TextChat.Messages.Reactions;

namespace Shared.Models.Requests.SessionActions.TextChat;

public class NewChatMessageModel
{
    public required string ChatId { get; init; }
    public required string SenderUserId { get; init; }
    public required DateTime SentTime { get; init; }
    public DateTime? DelayedSentTime { get; set; }
    public DateTime? DisposeTime { get; set; }

    public ChatTextContentDTO? TextContent { get; set; }
    public ChatRepostContentDTO? RepostContent { get; init; }

    public List<ChatImageContentDTO> Images { get; init; } = new();
    public List<ChatVideoContentDTO> Video { get; init; } = new();
    public List<ChatFileContentDTO> Files { get; init; } = new();

    public bool IsDelayed { get; set; }
    public bool IsEdited { get; set; }
    public bool IsReposted { get; set; }
    public bool IsDelivered { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsReadOnly { get; set; }
    public bool IsDisposable { get; set; }
}