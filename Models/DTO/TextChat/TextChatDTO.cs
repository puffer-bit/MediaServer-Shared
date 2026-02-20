namespace Shared.Models.DTO.TextChat;

public class TextChatDTO
{
    public required string Id { get; set; }
    public required string CoordinatorInstanceId { get; set; }
    public required string CreatorUserId { get; set; }
    public string? AdminUserId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? IconPath { get; set; }
    public int? Capacity { get; set; }

    public required Dictionary<string, TextChatUserDTO> Users { get; set; }

    public bool IsReadOnly { get; set; }
    public bool IsArchived { get; set; }
    public bool IsAttachmentsAllowed { get; set; }
    public bool IsVoiceMessagesAllowed { get; set; }
    public bool IsVideoMessagesAllowed { get; set; }
    public bool IsDelayedMessagesAllowed { get; set; }
}
