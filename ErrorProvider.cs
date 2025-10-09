using Shared.Enums;

namespace Shared;

public class ErrorProvider
{
    public static string GetErrorDescription(JoinSessionResult result)
    {
        if (result == JoinSessionResult.NoError)
        {
            return "Request successful completed";
        }

        if (result == JoinSessionResult.InternalError)
        {
            return "Internal server error";
        }

        if (result == JoinSessionResult.RoomFull)
        {
            return "Room is full";
        }

        if (result == JoinSessionResult.RoomNotExists)
        {
            return "Room does not exist";
        }

        throw new ArgumentOutOfRangeException(nameof(result), result, "Unknown result");
    }
    
    public static string GetErrorDescription(CreateSessionResult result)
    {
        if (result == CreateSessionResult.NoError)
        {
            return "Request successful completed";
        }

        if (result == CreateSessionResult.InternalError)
        {
            return "Internal server error";
        }

        if (result == CreateSessionResult.WrongCapacity)
        {
            return "Wrong room capacity";
        }

        if (result == CreateSessionResult.NameAlreadyUsed)
        {
            return "New name already used";
        }

        throw new ArgumentOutOfRangeException(nameof(result), result, "Unknown result");
    }
    
    public static string GetErrorDescription(LeaveSessionResult result)
    {
        if (result == LeaveSessionResult.NoError)
        {
            return "Request successful completed";
        }

        if (result == LeaveSessionResult.InternalError)
        {
            return "Internal server error";
        }

        throw new ArgumentOutOfRangeException(nameof(result), result, "Unknown result");
    }
    
    public static string GetErrorDescription(DeleteSessionResult result)
    {
        if (result == DeleteSessionResult.NoError)
        {
            return "Request successful completed";
        }

        if (result == DeleteSessionResult.InternalError)
        {
            return "Internal server error";
        }
        
        if (result == DeleteSessionResult.RoomContainsUsers)
        {
            return "Room contains users";
        }
        
        if (result == DeleteSessionResult.RoomNotExists)
        {
            return "Room not exists";
        }

        throw new ArgumentOutOfRangeException(nameof(result), result, "Unknown result");
    }
    
    public static string GetErrorDescription(SessionRequestResult result)
    {
        if (result == SessionRequestResult.NoError)
        {
            return "Request successful completed";
        }

        if (result == SessionRequestResult.InternalError)
        {
            return "Internal server error";
        }

        if (result == SessionRequestResult.RoomNotExists)
        {
            return "Room does not exist";
        }

        throw new ArgumentOutOfRangeException(nameof(result), result, "Unknown result");
    }
}