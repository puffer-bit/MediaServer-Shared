using Shared.Enums;
using Shared.Models.Responses.Sessions;

namespace Shared.Models.Responses.SessionActions;

public record DeleteSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Delete;
}
