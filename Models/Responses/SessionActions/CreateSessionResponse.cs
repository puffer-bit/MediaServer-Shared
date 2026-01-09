using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionActions;

public record CreateSessionResponse(
    SessionDTO? Session,
    CreateSessionResult Result )
{
    public static SessionRequestType Type => SessionRequestType.Create;
}
