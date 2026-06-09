using Shared.Enums;
using Shared.Models.Requests.SessionActions.Generic.Models;

namespace Shared.Parsers.Json;

public static class SessionDataRegistry
{
    private static readonly Dictionary<SessionType, Type> SessionDataTypeMap = new();

    static SessionDataRegistry()
    {
        RegisterDefaultTypes();
    }
    
    public static void RegisterSessionDataType(SessionType sessionType, Type dataType)
    {
        if (!typeof(CreateSessionData).IsAssignableFrom(dataType))
            throw new ArgumentException($"Type {dataType.Name} must derive from CreateSessionData");
        
        SessionDataTypeMap[sessionType] = dataType;
    }
    
    public static Type? GetSessionDataType(SessionType sessionType) =>
        SessionDataTypeMap.TryGetValue(sessionType, out var type) ? type : null;
    
    private static void RegisterDefaultTypes()
    {
        RegisterSessionDataType(SessionType.Chat, typeof(ChatSessionCreateData));
        RegisterSessionDataType(SessionType.Video, typeof(VideoSessionCreateData));
        // RegisterSessionDataType(SessionType.Voice, typeof(VoiceSessionCreateData));
    }
    
    public static void Clear()
    {
        SessionDataTypeMap.Clear();
    }
}

