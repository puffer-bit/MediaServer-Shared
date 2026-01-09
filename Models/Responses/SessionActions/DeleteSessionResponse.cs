using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record DeleteSessionResponse(
    DeleteSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Delete;
}
