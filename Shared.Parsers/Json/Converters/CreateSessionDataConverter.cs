using System.Text.Json;
using System.Text.Json.Serialization;
using Shared.Enums;
using Shared.Models.Requests.SessionActions.Generic.Models;

namespace Shared.Parsers.Json.Converters;

public class CreateSessionDataConverter : JsonConverter<CreateSessionData>
{
    public override CreateSessionData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        if (!root.TryGetProperty("SessionType", out var sessionTypeElement))
        {
            throw new JsonException("SessionType field is required in CreateSessionData");
        }

        var sessionType = (SessionType)sessionTypeElement.GetInt32();
        
        Type? targetType = SessionDataRegistry.GetSessionDataType(sessionType);

        if (targetType == null)
        {
            throw new JsonException($"Unknown SessionType: {sessionType}");
        }

        try
        {
            var data = JsonSerializer.Deserialize(root.GetRawText(), targetType, options);
            return (CreateSessionData?)data 
                ?? throw new JsonException($"Failed to deserialize {targetType.Name}");
        }
        catch (JsonException ex)
        {
            throw new JsonException($"Error deserializing CreateSessionData of type {sessionType}: {ex.Message}", ex);
        }
    }

    public override void Write(Utf8JsonWriter writer, CreateSessionData value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
    }
}

