using System;
using System.Text.Json;
using Xunit;
using Shared.Enums;
using Shared.Enums.WebRTC;
using Shared.Models;
using Shared.Models.Requests.SessionActions;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.SessionActions.Generic.Models;
using Shared.Parsers.Json;
using Shared.Parsers.Json.Converters;

namespace Shared.Tests;

public class BaseMessageConverterTests
{
    private readonly JsonSerializerOptions _jsonOptions;

    public BaseMessageConverterTests()
    {
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };
        
        _jsonOptions.Converters.Add(new BaseMessageConverter());
        _jsonOptions.Converters.Add(new CreateSessionDataConverter());

        MessageRegistry.Clear();
        MessageRegistry.RegisterRequestType(MessageType.SessionAction, typeof(CreateSessionRequest));
    }

    [Fact]
    public void BaseMessageConverter_ShouldPackAndUnpack_HeavyCreateSessionRequest()
    {
        var videoData = new VideoSessionCreateData(
            EngineType: WebRTCEngine.GStreamer,
            VideoCodecs: WebRTCVideoCodecs.H264,
            AudioCodecs: WebRTCAudioCodecs.Opus,
            Resolution: VideoResolutions.FHD,
            VideoBitrate: 3500,
            IsAudioTransferEnabled: true,
            IsSimulcastEnabled: true,
            DisableStun: false
        );

        var sessionModel = new CreateSessionModel(
            Name: "GStreamer Heavy Streaming Room",
            HostId: 42,
            Capacity: 10,
            SessionData: videoData
        );

        var createSessionRequest = new CreateSessionRequest(sessionModel)
        {
            RequestId = "req-test-uuid-2026"
        };

        var originalMessage = new BaseMessage
        {
            Id = "msg-envelope-111",
            UserId = 7,
            Type = MessageType.SessionAction,
            Data = createSessionRequest
        };

        string jsonResult = JsonSerializer.Serialize(originalMessage, _jsonOptions);
        
        Console.WriteLine("Generated JSON:");
        Console.WriteLine(jsonResult);

        var deserializedMessage = JsonSerializer.Deserialize<BaseMessage>(jsonResult, _jsonOptions);

        Assert.NotNull(deserializedMessage);
        Assert.Equal(originalMessage.Id, deserializedMessage.Id);
        Assert.Equal(originalMessage.UserId, deserializedMessage.UserId);
        Assert.Equal(originalMessage.Type, deserializedMessage.Type);

        Assert.NotNull(deserializedMessage.Data);
        var castedRequest = Assert.IsType<CreateSessionRequest>(deserializedMessage.Data);
        Assert.Equal("req-test-uuid-2026", castedRequest.RequestId);

        var castedModel = castedRequest.CreateSessionModel;
        Assert.Equal("GStreamer Heavy Streaming Room", castedModel.Name);
        Assert.Equal(42, castedModel.HostId);
        Assert.Equal(10, castedModel.Capacity);

        Assert.NotNull(castedModel.SessionData);
        
        var castedVideoData = Assert.IsType<VideoSessionCreateData>(castedModel.SessionData);
        
        Assert.Equal(SessionType.Video, castedVideoData.SessionType);
        Assert.Equal(WebRTCEngine.GStreamer, castedVideoData.EngineType);
        Assert.Equal(3500, castedVideoData.VideoBitrate);
        Assert.True(castedVideoData.IsAudioTransferEnabled);
        Assert.True(castedVideoData.IsSimulcastEnabled);
        Assert.False(castedVideoData.DisableStun);
    }
}