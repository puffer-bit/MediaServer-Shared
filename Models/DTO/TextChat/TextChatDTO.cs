using Shared.Models.DTO.TextChat.User;

namespace Shared.Models.DTO.TextChat;

public class TextChatDTO : SessionDTO
{
    public required string CreatorUserId { get; set; }
    public string? AdminUserId { get; set; }
    public string? Description { get; set; }
    public string? IconPath { get; set; }

    public required Dictionary<string, TextChatUserDTO> Users { get; set; }

    public bool IsReadOnly { get; set; }
    public bool IsArchived { get; set; }
    public bool IsAttachmentsAllowed { get; set; }
    public bool IsVoiceMessagesAllowed { get; set; }
    public bool IsVideoMessagesAllowed { get; set; }
    public bool IsDelayedMessagesAllowed { get; set; }
}
