using Shared.Enums;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.DataTransferObjects
{
    public class PeerDTO
    {
        public int Id { get; init; }
        public int UserId { get; init; }
        public bool IsAudioRequested { get; set; }
        public bool IsNegotiated { get; set; }
        public bool IsConnected { get; set; }
        public bool IsApproved { get; set; }
        public bool IsRejected { get; set; }
        public bool IsScreenShareActive { get; set; }
        public bool IsVideoShareActive { get; set; }
        public bool IsMicrophoneMuted { get; set; }
        public bool IsSoundMuted { get; set; }
        public bool IsAfk { get; set; }
        public HybridSessionPeerState State { get; set; }
        public string? AfkMessage { get; set; }

        public Dictionary<string, Outbound> Outbounds { get; init; }
        public Dictionary<string, Inbound> Inbounds { get; init; }
    }
}
