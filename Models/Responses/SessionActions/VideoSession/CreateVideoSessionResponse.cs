using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionActions;

public record CreateVideoSessionResponse(
    string RequestId,
    SessionDTO? Session,
    CreateSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Create;
}
