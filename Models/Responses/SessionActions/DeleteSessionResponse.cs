using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record DeleteSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : ISessionResponse
{
    public SessionRequestType Type => SessionRequestType.Delete;
}
