namespace Shared.Enums;

public enum FetchMessagesResult
{
    InternalError = -1,
    NoError = 0,
    UnexpectedError = 1,
    ChatNotExists = 2,
    InvalidResponse = 3,
    TimedOut = 4,
    WrongResponse = 5
}

public enum FetchMessageResult
{
    InternalError = -1,
    NoError = 0,
    UnexpectedError = 1,
    ChatNotExists = 2,
    InvalidResponse = 3,
    MessageNotExists = 4,
    TimedOut = 5,
    WrongResponse = 6
}

public enum AddMessageResult
{
    InternalError = -1,
    NoError = 0,
    SameMessageAlreadyExist = 1,
    ChatNotExists = 2,
    TimedOut = 3,
    InvalidResponse = 4,
    WrongResponse = 5
}

public enum EditMessageResult
{
    InternalError = -1,
    NoError = 0,
    MessageNotExists = 1,
    ChatNotExists = 2
}

public enum DeleteMessageResult
{
    InternalError = -1,
    NoError = 0,
    UnexpectedError = 1,
    MessageNotExists = 2,
    ChatNotExists = 3,
    TimedOut = 4,
    InvalidResponse = 5,
    WrongResponse = 6
}
