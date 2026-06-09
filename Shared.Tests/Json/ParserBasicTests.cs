using Shared.Models;
using Shared.Parsers.Json;
using Xunit;

namespace Shared.Tests.Json;

public class ParserBasicTests
{
    [Fact]
    public void Parser_Can_Instantiate()
    {
        // Act
        var parser = new JsonMessageParser();
        
        // Assert
        Assert.NotNull(parser);
    }

    [Fact]
    public void Parser_Can_Parse_Simple_Message()
    {
        // Arrange
        var parser = new JsonMessageParser();
        var json = @"{""type"": 11, ""data"": {}}";

        // Act
        var message = parser.Parse(json);

        // Assert
        Assert.NotNull(message);
        Assert.NotNull(message.Id);
    }

    [Fact]
    public void Parser_Can_Serialize_Message()
    {
        // Arrange
        var parser = new JsonMessageParser();
        var message = new BaseMessage
        {
            Id = "test-123",
            Type = Shared.Enums.MessageType.HeartbeatAction,
            Data = new { }
        };

        // Act
        var json = parser.Serialize(message);

        // Assert
        Assert.NotNull(json);
        Assert.Contains("test-123", json);
    }

    [Fact]
    public void Parser_RoundTrip_Preserves_Data()
    {
        // Arrange
        var parser = new JsonMessageParser();
        var original = new BaseMessage
        {
            Id = "roundtrip-test",
            Type = Shared.Enums.MessageType.SessionsStateChanged,
            Data = new { sessionId = "sess-001" }
        };

        // Act
        var json = parser.Serialize(original);
        var parsed = parser.Parse(json);

        // Assert
        Assert.Equal(original.Id, parsed.Id);
        Assert.Equal(original.Type, parsed.Type);
    }
}

