namespace Shared.Enums
{
    public interface ISessionRequestResult
    {
        
    }
    
    public enum CreateSessionResult
    {
        InternalError = -1,
        NoError = 0,
        NameAlreadyUsed = 1,
        WrongCapacity = 2,
        UnexceptedParameters = 3,
        TimedOut = 4
    }
    
    public enum EditSessionResult
    {
        InternalError = -1,
        NoError = 0,
        NameAlreadyUsed = 1,
        WrongCapacity = 2,
        UnexceptedParameters = 3,
        TimedOut = 4
    }
    
    public enum DeleteSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomContainsUsers = 1,
        RoomNotExists = 2,
        TimedOut
    }
        
    public enum JoinSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        RoomFull = 2,
        TimedOut = 4
    }
    
    public enum LeaveSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4
    }
    
    public enum SessionRequestResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4
    }
    
    public enum HandleMessageResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        ForbiddenMessage = 2,
        JsonParseError = 3
    }
    
    public enum ValidateMessageResult
    {
        NoError = 0,
        NotExceptedError = 1,
        NullDataReceived = 2,
        JsonParseError = 3,
        ServerAnswerReceived = 4,
        ForbiddenData = 5,
        CastError = 6
    }
    
    public enum WebRTCNegotiationResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1
    }
}

