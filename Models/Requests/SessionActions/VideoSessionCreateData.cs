using Shared.Enums;
using Shared.Enums.WebRTC;
using Shared.Models.Requests.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions;

public record VideoSessionCreateData(
    WebRTCEngine EngineType,
    WebRTCVideoCodecs VideoCodecs = WebRTCVideoCodecs.H264,
    WebRTCAudioCodecs AudioCodecs = WebRTCAudioCodecs.PCM,
    VideoResolutions Resolution = VideoResolutions.FHD,
    int? VideoBitrate = 2500,
    bool IsAudioTransferEnabled = false,
    bool IsDataChannelEnabled = false,
    bool IsSimulcastEnabled = false,
    bool IsTunnelingEnabled = false,
    bool IsProxyActive = false,
    bool DisableStun = false,
    bool DisableTurn = false
) : ICreateSessionData
{
    public SessionType Type => SessionType.Video;
}
