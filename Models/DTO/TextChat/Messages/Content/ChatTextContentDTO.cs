namespace Shared.Models.DTO.TextChat.Messages.Content;

public class ChatTextContentDTO
{
    public required string Text { get; init; }
    
    public ChatContentType Type => ChatContentType.Text;
}