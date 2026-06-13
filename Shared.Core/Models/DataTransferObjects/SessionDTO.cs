using System.Text.Json.Serialization;
using Shared.Enums;
using Shared.Models.DataTransferObjects.TextChat;

namespace Shared.Models.DataTransferObjects
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type",
        UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor)]
    
    [JsonDerivedType(typeof(TextChatDTO), typeDiscriminator: 1)]
    [JsonDerivedType(typeof(VideoSessionDTO), typeDiscriminator: 2)]
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
