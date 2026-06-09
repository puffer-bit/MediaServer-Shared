using System;
using System.Text.Json;
using Xunit;
using Shared.Enums;
using Shared.Models;
using Shared.Models.Requests.SessionActions;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.SessionActions.Generic.Models;
using Shared.Parsers.Json;
using Shared.Parsers.Json.Converters;

namespace Shared.Tests;

public class BaseMessageConverterAdvancedTests
{
    private readonly JsonSerializerOptions _jsonOptions;

    public BaseMessageConverterAdvancedTests()
    {
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true 
        };
        _jsonOptions.Converters.Add(new BaseMessageConverter());
        _jsonOptions.Converters.Add(new CreateSessionDataConverter());

        MessageRegistry.Clear();
        MessageRegistry.RegisterRequestType(MessageType.SessionAction, typeof(CreateSessionRequest));
    }

    [Fact]
    public void Read_ShouldHandle_ExtremeValuesAndBoundaryData()
    {
        // --- ARRANGE ---
        var extremeJson = """
        {
            "Id": "msg-max-⚡-2026",
            "UserId": 2147483647,
            "Type": 6,
            "Data": {
                "CreateSessionModel": {
                    "Name": "部屋\tСтриминг!@#$%^&*()_+=\n",
                    "HostId": 2147483647,
                    "Capacity": 0,
                    "SessionData": {
                        "EngineType": 2,
                        "VideoCodecs": 1,
                        "AudioCodecs": 1,
                        "Resolution": 4,
                        "VideoBitrate": 0, 
                        "IsAudioTransferEnabled": false,
                        "IsSimulcastEnabled": false,
                        "DisableStun": true,
                        "SessionType": 1
                    }
                },
                "RequestId": "" 
            }
        }
        """;

        // --- ACT ---
        var message = JsonSerializer.Deserialize<BaseMessage>(extremeJson, _jsonOptions);

        // --- ASSERT ---
        Assert.NotNull(message);
        Assert.Equal("msg-max-⚡-2026", message.Id);
        Assert.Equal(int.MaxValue, message.UserId);

        var request = Assert.IsType<CreateSessionRequest>(message.Data);
        var model = request.CreateSessionModel;
        
        Assert.Equal("部屋\tСтриминг!@#$%^&*()_+=\n", model.Name);
        Assert.Equal(int.MaxValue, model.HostId);
        Assert.Equal(0, model.Capacity);

        var videoData = Assert.IsType<VideoSessionCreateData>(model.SessionData);
        Assert.Equal(0, videoData.VideoBitrate);
        Assert.True(videoData.DisableStun);
        Assert.Equal("", request.RequestId);
    }

    [Fact]
    public void Read_Should_IgnoreExtraExtensionFields()
    {
        // --- ARRANGE ---
        var jsonWithExtraFields = """
                                  {
                                      "Id": "msg-extra-001",
                                      "UserId": 99,
                                      "Type": 6,
                                      "ExtraField": "some-temporary-token-123", 
                                      "Data": {
                                          "CreateSessionModel": {
                                              "Name": "Strict PascalCase Room",
                                              "HostId": 1,
                                              "Capacity": 5,
                                              "CustomTimestamp": 1717876543, 
                                              "SessionData": {
                                                  "EngineType": 2,
                                                  "VideoBitrate": 2000,
                                                  "SessionType": 1
                                              }
                                          },
                                          "RequestId": "req-pascal-uuid"
                                      }
                                  }
                                  """;

        // --- ACT ---
        var message = JsonSerializer.Deserialize<BaseMessage>(jsonWithExtraFields, _jsonOptions);

        // --- ASSERT ---
        Assert.NotNull(message);
        Assert.Equal("msg-extra-001", message.Id);
        Assert.Equal(99, message.UserId);
        Assert.Equal(MessageType.SessionAction, message.Type);

        var request = Assert.IsType<CreateSessionRequest>(message.Data);
        Assert.Equal("req-pascal-uuid", request.RequestId);
    
        var model = request.CreateSessionModel;
        Assert.Equal("Strict PascalCase Room", model.Name);

        var videoData = Assert.IsType<VideoSessionCreateData>(model.SessionData);
        Assert.Equal(2000, videoData.VideoBitrate);
    }
}