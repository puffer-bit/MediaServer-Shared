using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionActions;

public record CreateSessionResponse(
    string RequestId,
    SessionDTO? Session,
    CreateSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Create;
}
