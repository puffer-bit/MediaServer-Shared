using System.Text.Json;
using System.Text.Json.Serialization;
using Shared.Enums;
using Shared.Models;
using Shared.Models.Requests;
using Shared.Models.Responses;
using Shared.Models.Notifications;
using Shared.Parsers.Json.Converters;

namespace Shared.Parsers.Json;

public class JsonMessageParser
{
    private readonly JsonSerializerOptions _options;

    public JsonMessageParser()
    {
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters =
            {
                new BaseMessageConverter(),
                new CreateSessionDataConverter()
            }
        };
    }
    
    public BaseMessage Parse(string json)
    {
        try
        {
            var message = JsonSerializer.Deserialize<BaseMessage>(json, _options)
                ?? throw new JsonException("Не удалось десериализовать сообщение");
            return message;
        }
        catch (JsonException ex)
        {
            throw new JsonException($"Ошибка парсинга JSON: {ex.Message}", ex);
        }
    }
    
    public async Task<BaseMessage> ParseAsync(Stream stream)
    {
        try
        {
            var message = await JsonSerializer.DeserializeAsync<BaseMessage>(stream, _options)
                ?? throw new JsonException("Не удалось десериализовать сообщение");
            return message;
        }
        catch (JsonException ex)
        {
            throw new JsonException($"Ошибка парсинга JSON: {ex.Message}", ex);
        }
    }
    
    public string Serialize(BaseMessage message)
    {
        return JsonSerializer.Serialize(message, _options);
    }
    
    public async Task SerializeAsync(Stream stream, BaseMessage message)
    {
        await JsonSerializer.SerializeAsync(stream, message, _options);
    }
    
    public T? ExtractData<T>(BaseMessage message) where T : BaseMessageData
    {
        if (message.Data is null)
            return null;

        try
        {
            return message.Data switch
            {
                JsonElement element => JsonSerializer.Deserialize<T>(element.GetRawText(), _options),
                T typedData => typedData,
                _ => JsonSerializer.Deserialize<T>(
                    JsonSerializer.Serialize(message.Data, _options),
                    _options)
            };
        }
        catch
        {
            return null;
        }
    }
    
    public BaseMessage CreateRequest(MessageType type, Request data, int? userId = null)
    {
        return new BaseMessage
        {
            Type = type,
            Data = data,
            UserId = userId
        };
    }
    
    public BaseMessage CreateResponse(MessageType type, Response data, string? requestId = null, int? userId = null)
    {
        return new BaseMessage
        {
            Type = type,
            Data = data,
            UserId = userId
        };
    }
    
    public BaseMessage CreateNotification(MessageType type, Notification data, int? userId = null)
    {
        return new BaseMessage
        {
            Type = type,
            Data = data,
            UserId = userId
        };
    }
    
    public BaseMessageDataType DetermineDataType(string json)
    {
        try
        {
            using var document = JsonDocument.Parse(json);
            var root = document.RootElement;

            if (root.TryGetProperty("Data", out var dataElement) && dataElement.ValueKind != JsonValueKind.Null)
            {
                if (dataElement.TryGetProperty("RequestId", out _))
                {
                    return BaseMessageDataType.Response;
                }
                
                return BaseMessageDataType.Request;
            }

            return BaseMessageDataType.Request;
        }
        catch
        {
            return BaseMessageDataType.Request;
        }
    }
}


