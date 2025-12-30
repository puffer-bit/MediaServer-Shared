namespace Shared.Models.DTO.VideoSession;

public class VideoSessionDTO : SessionDTO
{
    public string? HostPeerId { get; set; }
    public bool IsHostConnected { get; set; }
    public bool IsAudioRequested { get; set; }
    public bool IsHostMustApprove { get; set; }
    public List<PeerDTO> Peers { get; set; }
}