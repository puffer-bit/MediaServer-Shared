using System.Collections.Generic;
using Shared.Models.DTO;

namespace Shared.Models;

public class VideoSessionDTO : SessionDTO
{
    public string? HostPeerId { get; set; }
    public bool IsHostConnected { get; set; }
    public bool IsAudioRequested { get; set; }
    public bool IsHostMustApprove { get; set; }
    public List<PeerDTO> Peers { get; set; }
}