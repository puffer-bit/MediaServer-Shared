using Shared.Enums;

namespace Shared.Models
{
    public abstract record BaseMessage
    {
        public string Id { get; init; } = GenerateTimestampId();
        
        public int UserId { get; set; }
        
        private static string GenerateTimestampId() 
            => $"{DateTime.UtcNow.Ticks}_{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}
