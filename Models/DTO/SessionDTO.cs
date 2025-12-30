
using Shared.Enums;

namespace Shared.Models.DTO
{
    public class SessionDTO
    {
        public required string Id { get; set; }
        public required string CoordinatorInstanceId { get; set; }
        public required string Name { get; set; }
        public required string? HostId { get; set; }
        public required int Capacity { get; set; }
        public required SessionType SessionType { get; set; }
        public bool IsEntered { get; set; }
    }
}
