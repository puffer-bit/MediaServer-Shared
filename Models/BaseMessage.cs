using Shared.Enums;

namespace Shared.Models
{
    public class BaseMessage
    {
        public string MessageId { get; init; }
        public string? UserId { get; set; }
        public MessageType Type { get; set; }
        public object Data { get; set; }

        public BaseMessage()
        {
            
        }

        public BaseMessage(BaseMessage message)
        {
            MessageId = message.MessageId;
            UserId = message.UserId;
            Type = message.Type;
            Data = message.Data;
        }
        
        public BaseMessage(MessageType type, object data)
        {
            MessageId = GenerateTimestampId();
            Type = type;
            Data = data;
        }

        public BaseMessage(string userId, MessageType type, object data) 
        {
            MessageId = GenerateTimestampId();
            UserId = userId;
            Type = type;
            Data = data;
        }
        
        public static string GenerateTimestampId()
        {
            return $"{DateTime.UtcNow.Ticks}_{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
