using System;
using System.Text.Json;
using Xunit;
using Shared.Enums;
using Shared.Models;
using Shared.Models.Requests;
using Shared.Parsers.Json;
using Shared.Parsers.Json.Converters;

namespace Shared.Tests;

public class BaseMessageConverterEdgeCasesTests
{
    private readonly JsonSerializerOptions _jsonOptions;

    public BaseMessageConverterEdgeCasesTests()
    {
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        _jsonOptions.Converters.Add(new BaseMessageConverter());
        
        MessageRegistry.Clear();
    }

    [Fact]
    public void Read_ShouldReturnJsonElement_WhenMessageTypeIsUnknown()
    {
        var unknownTypeJson = """
        {
            "Id": "msg-unknown-999",
            "UserId": 10,
            "Type": 9999, 
            "Data": {
                "CustomField": "Some valuable client data",
                "Array": [1, 2, 3]
            }
        }
        """;

        var message = JsonSerializer.Deserialize<BaseMessage>(unknownTypeJson, _jsonOptions);

        Assert.NotNull(message);
        Assert.Equal("msg-unknown-999", message.Id);
        Assert.Equal((MessageType)9999, message.Type);
        
        Assert.NotNull(message.Data);
        var jsonElement = Assert.IsType<JsonElement>(message.Data);
        
        Assert.Equal("Some valuable client data", jsonElement.GetProperty("CustomField").GetString());
        Assert.Equal(1, jsonElement.GetProperty("Array")[0].GetInt32());
    }

    [Fact]
    public void ReadAndWrite_ShouldHandle_NullOrMissingData()
    {
        var jsonWithoutData = """
        {
            "Id": "msg-ping-001",
            "UserId": null,
            "Type": 1
        }
        """;

        var message = JsonSerializer.Deserialize<BaseMessage>(jsonWithoutData, _jsonOptions);

        Assert.NotNull(message);
        Assert.Null(message.UserId);
        Assert.Null(message.Data); // Проверяем, что нет NullReferenceException
    }

    [Fact]
    public void Read_ShouldReturnRawJsonElement_WhenDataHasInvalidStructureForClass()
    {
        MessageRegistry.RegisterRequestType(MessageType.Undefined, typeof(DummyTestRequest));

        var invalidDataStructureJson = """
                                       {
                                           "Id": "msg-broken-007",
                                           "Type": 0,
                                           "Data": {
                                               "SomeField": [1, 2] 
                                           }
                                       }
                                       """;

        // --- ACT ---
        var message = JsonSerializer.Deserialize<BaseMessage>(invalidDataStructureJson, _jsonOptions);

        // --- ASSERT ---
        Assert.NotNull(message);
        Assert.Equal("msg-broken-007", message.Id);
        
        Assert.NotNull(message.Data);
        var jsonElement = Assert.IsType<JsonElement>(message.Data);
        
        Assert.Equal(JsonValueKind.Array, jsonElement.GetProperty("SomeField").ValueKind);
    }
}

public record DummyTestRequest(string SomeField) : Request;