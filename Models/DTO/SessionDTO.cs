
using System.Text.Json.Serialization;
using Shared.Enums;
using Shared.Models.DTO.TextChat;

namespace Shared.Models.DTO
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "SessionType")]
    [JsonDerivedType(typeof(TextChatDTO), typeDiscriminator: (int)SessionType.Chat)]
    [JsonDerivedType(typeof(VideoSessionDTO), typeDiscriminator: (int)SessionType.Video)]
    [JsonDerivedType(typeof(VoiceSessionDTO), typeDiscriminator: (int)SessionType.Voice)]
    public class SessionDTO
    {
        public required int Id { get; set; }
        public required string CoordinatorInstanceId { get; set; }
        public required string Name { get; set; }
        public required int Capacity { get; set; }
        public required SessionType SessionType { get; set; }
        public bool IsEntered { get; set; }
    }
}
