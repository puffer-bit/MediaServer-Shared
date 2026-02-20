using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public record DeleteVideoSessionResponse(
    string RequestId,
    DeleteSessionResult Result ) : IVideoSessionResponse
{
    public SessionRequestType Type => SessionRequestType.Delete;
}
