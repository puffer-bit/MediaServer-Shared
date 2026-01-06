using System;
using Shared.Enums;

namespace Shared.Models
{
    public class BaseMessage
    {
        public string Id { get; init; }
        public string? UserId { get; set; }
        public MessageType Type { get; set; }
        public object Data { get; set; }

        public BaseMessage()
        {
            
        }

        public BaseMessage(BaseMessage message)
        {
            Id = message.Id;
            UserId = message.UserId;
            Type = message.Type;
            Data = message.Data;
        }
        
        public BaseMessage(MessageType type, object data)
        {
            Id = GenerateTimestampId();
            Type = type;
            Data = data;
        }

        public BaseMessage(string userId, MessageType type, object data) 
        {
            Id = GenerateTimestampId();
            UserId = userId;
            Type = type;
            Data = data;
        }
        
        private static string GenerateTimestampId()
        {
            return $"{DateTime.UtcNow.Ticks}_{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
