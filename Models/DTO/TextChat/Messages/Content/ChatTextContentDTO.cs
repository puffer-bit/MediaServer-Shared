namespace Shared.Models.DTO.TextChat;

public class ChatTextContentDTO
{
    public required string Text { get; init; }
    
    public ChatContentType Type => ChatContentType.Text;
}