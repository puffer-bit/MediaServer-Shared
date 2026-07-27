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
        TimedOut = 4,
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
        TimedOut,
    }
        
    public enum JoinSessionResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        RoomFull = 2,
        TimedOut = 4,
        InsufficientPermissions,
        SFUError,
        UnknowSessionType
    }
    
    public enum HybridSessionJoinResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        RoomFull = 2,
        TimedOut = 4,
        InsufficientPermissions,
        SFUError,
        UnknowSessionType
    }
    
    public enum HybridSessionLeaveResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        TimedOut = 4,
        InsufficientPermissions,
        SFUError,
        UnknowSessionType,
        NotMemberOfSession
    }
    
    public enum StartScreenShareResult
    {
        InternalError = -1,
        NoError = 0,
        UnsupportedMedia = 1,
        InsufficientPermissions = 2,
        PeerNotExists,
        SFUError
    }
    
    public enum StopScreenShareResult
    {
        InternalError = -1,
        NoError = 0,
        ScreenShareNotActive = 1,
        InsufficientPermissions = 2,
        PeerNotExists,
        SFUError
    }
    
    public enum StartVideoShareResult
    {
        InternalError = -1,
        NoError = 0,
        UnsupportedMedia = 1,
        InsufficientPermissions = 2,
        SFUError,
        PeerNotExists
    }
    
    public enum StopVideoShareResult
    {
        InternalError = -1,
        NoError = 0,
        ScreenShareNotActive = 1,
        InsufficientPermissions = 2,
    }
    
    public enum UpdateScreenShareResult
    {
        InternalError = -1,
        NoError = 0,
        UnsupportedMedia = 1,
        InsufficientPermissions = 2,
        PeerNotExists,
        SFUError
    }
    
    public enum UpdateVideoShareResult
    {
        InternalError = -1,
        NoError = 0,
        UnsupportedMedia = 1,
        InsufficientPermissions = 2,
    }
    
    public enum MuteMicrophoneResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
    }
    
    public enum UnmuteMicrophoneResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
    }
    
    public enum MuteSoundResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
    }
    
    public enum UnmuteSoundResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
    }
    
    public enum SetAfkResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
        AfkModeDisabled
    }
    
    public enum ResetAfkResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
        AfkModeDisabled
    }
    
    public enum PokeResult
    {
        InternalError = -1,
        NoError = 0,
        InsufficientPermissions = 2,
        PokeDisabled
    }
    
    public enum LeaveFromSessionResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4,
        ParticipantNotExists
    }
    
    public enum LeaveSessionResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        TimedOut = 4,
        PeerNotExists,
        UnknowSessionType
    }
    
    public enum BanFromSessionResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        HostCannotBeBanned = 2,
        InsufficientPermissions = 3,
        TimedOut = 4,
        UnknowSessionType
    }
    
    public enum ApproveUserSessionResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        TimedOut = 4,
        PeerNotExists,
        AlreadyRejected,
        SFUError,
        UnknowSessionType
    }
    
    public enum RejectUserSessionResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExists = 1,
        TimedOut = 4,
        PeerNotExists,
        AlreadyApproved,
        UnknowSessionType
    }
    
    public enum SessionRequestResult
    {
        InternalError = -1,
        NoError = 0,
        RoomNotExists = 1,
        TimedOut = 4,
        WrongResponse
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
        NoUserId = 5,
        GatewayNotFound
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
        
    public enum SFUTransportCreateResult
    {
        InternalError = -1,
        NoError = 0,
        SFUServiceError = 3,
        SFUServiceNotAvailable = 4,
        PortAllocationFailed = 5,
        MaxTransportsReached = 6
    }
    
    public enum SFUOutboundCreateResult
    {
        InternalError = -1,
        NoError = 0,
        UnsupportedMediaType = 2,
        SFUServiceError = 3,
        SFUServiceNotAvailable = 4,
        DuplicateOutbound = 5,
        TransportClosed = 7
    }

    public enum SFUOutboundDowngradeResult
    {
        InternalError = -1,
        NoError = 0,
        SFUServiceError = 3,
        SFUServiceNotAvailable = 4,
        InvalidSSRC = 1,
        AlreadyDowngraded = 5,
    }
    
    public enum SFUOutboundUpgradeResult
    {
        InternalError = -1,
        NoError = 0,
        SFUServiceError = 3,
        SFUServiceNotAvailable = 4,
        InvalidSSRC = 1,
        AlreadyUpgraded = 5,
    }

    public enum FetchMessagesResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        ChatDontExist = 3,
        InvalidResponse,
        TimedOut,
        WrongResponse
    }
    
    public enum FetchMessageResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        ChatDontExist = 3,
        InvalidResponse,
        MessageDoesntExist,
        TimedOut,
        WrongResponse
    }
    
    public enum AddMessageResult
    {
        InternalError = -1,
        NoError = 0,
        SameMessageAlreadyExist = 1,
        ChatDontExist = 3,
        TimedOut,
        InvalidResponse,
        WrongResponse
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
        TimedOut,
        InvalidResponse,
        WrongResponse
    }
    
    public enum TextChatHistoryResult
    {
        InternalError = -1,
        NoError = 0,
        NotExceptedError = 1,
        MessageDontExist = 2,
        ChatDontExist = 3,
        InavlidResponse,
        TimedOut
    }
    
    public enum PeerListRequestResult
    {
        InternalError = -1,
        NoError = 0,
        SessionNotExist = 1,
        SessionIsNotHybrid = 2
        
    }
}

