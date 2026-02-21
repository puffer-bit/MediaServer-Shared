using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public record DeleteSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Delete;
}
