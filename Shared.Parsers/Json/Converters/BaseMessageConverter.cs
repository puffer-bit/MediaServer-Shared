using System.Text.Json;
using System.Text.Json.Serialization;
using Shared.Enums;
using Shared.Models;
using Shared.Models.Requests.SessionActions.Generic;
using Shared.Models.Requests.SessionActions.Generic.Models;

namespace Shared.Parsers.Json.Converters;

public class BaseMessageConverter : JsonConverter<BaseMessage>
{
    public override BaseMessage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        string id;
        if (root.TryGetProperty("Id", out var idProp) && idProp.ValueKind == JsonValueKind.String)
        {
            var idValue = idProp.GetString();
            id = !string.IsNullOrEmpty(idValue) ? idValue : Guid.NewGuid().ToString();
        }
        else
        {
            id = Guid.NewGuid().ToString();
        }
            
        var userId = root.TryGetProperty("UserId", out var userIdProp) && userIdProp.ValueKind == JsonValueKind.Number
            ? userIdProp.GetInt32()
            : (int?)null;
            
        var messageType = root.TryGetProperty("Type", out var typeProp) && typeProp.ValueKind == JsonValueKind.Number
            ? (MessageType)typeProp.GetInt32()
            : MessageType.Undefined;

        object? dataObject = null;

        if (root.TryGetProperty("Data", out var dataElement) && dataElement.ValueKind != JsonValueKind.Null)
        {
            dataObject = DeserializeData(dataElement, messageType, options);
        }

        return new BaseMessage { Id = id, UserId = userId, Type = messageType, Data = dataObject! };
    }
    
    private object? DeserializeData(JsonElement dataElement, MessageType messageType, JsonSerializerOptions options)
    {
        try
        {
            if (messageType == MessageType.SessionAction && IsCreateSessionRequest(dataElement))
            {
                return DeserializeCreateSessionRequest(dataElement, options);
            }

            Type? requestType = MessageRegistry.GetRequestType(messageType);
            Type? responseType = MessageRegistry.GetResponseType(messageType);
            Type? notificationType = MessageRegistry.GetNotificationType(messageType);

            if (requestType != null)
            {
                return JsonSerializer.Deserialize(dataElement.GetRawText(), requestType, options);
            }
            if (responseType != null)
            {
                return JsonSerializer.Deserialize(dataElement.GetRawText(), responseType, options);
            }
            if (notificationType != null)
            {
                return JsonSerializer.Deserialize(dataElement.GetRawText(), notificationType, options);
            }

            return (object)dataElement.Clone();
        }
        catch (JsonException)
        {
            return (object)dataElement.Clone();
        }
    }
    
    private bool IsCreateSessionRequest(JsonElement dataElement)
    {
        return dataElement.TryGetProperty("CreateSessionModel", out _) &&
               (dataElement.TryGetProperty("ActionType", out var actionType) &&
                actionType.GetInt32() == (int)SessionActionType.CreateRequest ||
               !dataElement.TryGetProperty("ActionType", out _));
    }
    
    private CreateSessionRequest DeserializeCreateSessionRequest(JsonElement dataElement, JsonSerializerOptions options)
    {
        try
        {
            if (!dataElement.TryGetProperty("CreateSessionModel", out var modelElement))
            {
                throw new JsonException("CreateSessionModel field is required");
            }

            var name = modelElement.TryGetProperty("Name", out var nameProp)
                ? nameProp.GetString() ?? ""
                : "";

            var hostId = modelElement.TryGetProperty("HostId", out var hostIdProp)
                ? hostIdProp.GetInt32()
                : throw new JsonException("HostId field is required");

            var capacity = modelElement.TryGetProperty("Capacity", out var capacityProp)
                ? capacityProp.GetInt32()
                : throw new JsonException("Capacity field is required");

            if (!modelElement.TryGetProperty("SessionData", out var sessionDataElement))
            {
                throw new JsonException("SessionData field is required in CreateSessionModel");
            }

            var sessionDataOptions = new JsonSerializerOptions(options);
            if (!sessionDataOptions.Converters.Any(c => c is CreateSessionDataConverter))
            {
                sessionDataOptions.Converters.Add(new CreateSessionDataConverter());
            }

            var sessionData = JsonSerializer.Deserialize<CreateSessionData>(
                sessionDataElement.GetRawText(),
                sessionDataOptions)
                ?? throw new JsonException("Failed to deserialize SessionData");

            var model = new CreateSessionModel(name, hostId, capacity, sessionData);

            var request = new CreateSessionRequest(model);

            if (dataElement.TryGetProperty("RequestId", out var requestIdProp))
            {
                var requestId = requestIdProp.GetString();
                if (requestId != null)
                {
                    request = request with { RequestId = requestId };
                }
            }

            return request;
        }
        catch (JsonException ex)
        {
            throw new JsonException($"Error deserializing CreateSessionRequest: {ex.Message}", ex);
        }
    }

    public override void Write(Utf8JsonWriter writer, BaseMessage value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        writer.WriteString("Id", value.Id);
        if (value.UserId.HasValue) 
            writer.WriteNumber("UserId", value.UserId.Value);
        writer.WriteNumber("Type", (int)value.Type);
        
        writer.WritePropertyName("Data");
        if (value.Data != null)
        {
            JsonSerializer.Serialize(writer, value.Data, value.Data.GetType(), options);
        }
        else
        {
            writer.WriteNullValue();
        }
            
        writer.WriteEndObject();
    }
}