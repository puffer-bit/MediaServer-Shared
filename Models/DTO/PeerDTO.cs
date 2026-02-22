using Shared.Enums;

namespace Shared.Models.DTO
{
    public class PeerDTO
    {
        public string Id { get; set; }
        public UserDTO User { get; set; }
        public bool IsStreamHost { get; set; }
        public bool IsAudioRequested { get; set; }
        public VideoSessionPeerState State { get; set; }
        public bool IsNegotiated { get; set; }
        public bool IsConnected { get; set; }
        public bool? IsApproved { get; set; }
        public bool IsRejected { get; set; }
    }
}
