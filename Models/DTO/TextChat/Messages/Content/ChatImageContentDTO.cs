namespace Shared.Models.DTO.TextChat;

public class ChatImageContentDTO
{
    public required string Id { get; init; }
    public required string FileName { get; init; }
    public string? Thumbnail { get; set; }
    public string? Description { get; init; }
    public required long Size { get; init; }
    public required string MimeType { get; init; }
    
    public required int Width { get; init; }
    public required int Height { get; init; }
    
    public ChatContentType Type => ChatContentType.Image;
}