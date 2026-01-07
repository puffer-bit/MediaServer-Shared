namespace Shared.Models.DTO;

public class VideoSessionDTO : SessionDTO
{
    public bool IsHostConnected { get; set; }
    public bool IsAudioRequested { get; set; }
    public bool IsHostMustApprove { get; set; }
    public IList<PeerDTO> Peers { get; set; }
}