using System.Collections.Generic;

namespace Shared.Models;

public class VideoSessionDTO : SessionDTO
{
    public string? HostPeerId { get; set; }
    public bool IsHostConnected { get; set; }
    public bool IsAudioRequested { get; set; }
    public List<UserDTO> Users { get; set; }
}