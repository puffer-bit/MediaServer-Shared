using Shared.Enums;
using Shared.Enums.WebRTC;

namespace Shared.Models.Requests.SessionActions.Generic.Models;

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
) : CreateSessionData
{
    public override SessionType SessionType { get; init; } = SessionType.Video;
}
