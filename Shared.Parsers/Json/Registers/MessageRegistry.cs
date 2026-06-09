using Shared.Enums;
using Shared.Models;
using Shared.Models.Requests;
using Shared.Models.Responses;
using Shared.Models.Notifications;

namespace Shared.Parsers.Json;

public static class MessageRegistry
{
    private static readonly Dictionary<MessageType, Type> RequestTypeMap = new();
    private static readonly Dictionary<MessageType, Type> ResponseTypeMap = new();
    private static readonly Dictionary<MessageType, Type> NotificationTypeMap = new();

    static MessageRegistry()
    {
        RegisterDefaultTypes();
    }
    
    public static void RegisterRequestType(MessageType messageType, Type requestType)
    {
        if (!typeof(Request).IsAssignableFrom(requestType))
            throw new ArgumentException($"Type {requestType.Name} must derive from Request");
        
        RequestTypeMap[messageType] = requestType;
    }
    
    public static void RegisterResponseType(MessageType messageType, Type responseType)
    {
        if (!typeof(Response).IsAssignableFrom(responseType))
            throw new ArgumentException($"Type {responseType.Name} must derive from Response");
        
        ResponseTypeMap[messageType] = responseType;
    }
    
    public static void RegisterNotificationType(MessageType messageType, Type notificationType)
    {
        if (!typeof(Notification).IsAssignableFrom(notificationType))
            throw new ArgumentException($"Type {notificationType.Name} must derive from Notification");
        
        NotificationTypeMap[messageType] = notificationType;
    }
    
    public static Type? GetRequestType(MessageType messageType) => 
        RequestTypeMap.TryGetValue(messageType, out var type) ? type : null;
    
    public static Type? GetResponseType(MessageType messageType) => 
        ResponseTypeMap.TryGetValue(messageType, out var type) ? type : null;
    
    public static Type? GetNotificationType(MessageType messageType) => 
        NotificationTypeMap.TryGetValue(messageType, out var type) ? type : null;
    
    private static void RegisterDefaultTypes()
    {
        // Здесь будут регистрироваться типы из вашего проекта
        // Примерно так:
        // RegisterRequestType(MessageType.WebRTCAction, typeof(WebRTCRequest));
        // RegisterRequestType(MessageType.SessionAction, typeof(SessionActionRequest));
        // и т.д.
        
        // Это можно заполнить позже посредством reflection или вручную
    }
    
    public static void Clear()
    {
        RequestTypeMap.Clear();
        ResponseTypeMap.Clear();
        NotificationTypeMap.Clear();
    }
}

