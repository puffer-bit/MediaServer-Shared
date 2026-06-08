using System;
using Shared.Enums;

namespace Shared.Models
{
    public class BaseMessage
    {
        public string Id { get; init; } = GenerateTimestampId();
        public int? UserId { get; set; }
        public MessageType Type { get; set; }
        public object Data { get; set; }
        
        public BaseMessage(BaseMessage message)
        {
            Id = message.Id;
            UserId = message.UserId;
            Type = message.Type;
            Data = message.Data;
        }
        
        public BaseMessage(MessageType type, object data)
        {
            Type = type;
            Data = data;
        }

        public BaseMessage(int userId, MessageType type, object data) 
        {
            UserId = userId;
            Type = type;
            Data = data;
        }

        public BaseMessage()
        {

        }

        private static string GenerateTimestampId()
        {
            return $"{DateTime.UtcNow.Ticks}_{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }
}
