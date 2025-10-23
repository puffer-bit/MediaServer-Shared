using Shared.Enums;

namespace Shared.Models.DTO
{
    public class PeerDTO
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public bool IsStreamHost { get; set; }
        public bool IsAudioRequested { get; set; }
        public VideoSessionApproveState ApproveState { get; set; }
    }
}
