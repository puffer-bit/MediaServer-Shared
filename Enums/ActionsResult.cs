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
        TimedOut = 4,
    }
    
    public enum LeaveFromSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        HostCannotBeKicked = 2,
        InsufficientPermissions = 3,
        TimedOut = 4,
        ParticipantNotExists
    }
    
    public enum LeaveSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4,
        ParticipantNotExists
    }
    
    public enum BanFromSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        HostCannotBeBanned = 2,
        InsufficientPermissions = 3,
        TimedOut = 4
    }
    
    public enum ApproveUserSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4,
        ParticipantNotExists,
        AlreadyRejected
    }
    
    public enum RejectUserSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4,
        ParticipantNotExists,
        AlreadyApproved
    }
    
    public enum SessionRequestResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4
    }
    
    public enum UsersRequestResult
    {
        InternalError = -1,
        NoError = 0,
        UserNotFounded = 1,
        TimedOut = 4
    }
    
    public enum HandleMessageResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        ForbiddenMessage = 2,
        ForbiddenRequest = 3,
        JsonParseError = 4,
        NoUserId = 5
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

    public enum FetchMessagesResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        ChatDontExist = 3,
    }
    
    public enum AddMessageResult
    {
        InternalError = -1,
        NoError = 0,
        SameMessageAlreadyExist = 1,
        ChatDontExist = 3,
    }

    public enum EditMessageResult
    {
        InternalError = -1,
        NoError = 0,
        MessageDontExist = 2,
        ChatDontExist = 3,
    }
    
    public enum DeleteMessageResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        MessageDontExist = 2,
        ChatDontExist = 3,
    }
}

