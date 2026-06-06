using Shared.Enums;

namespace Shared.Models.Responses.SessionActions.VideoSession;

public interface IVideoSessionResponse : IResponse
{
    SessionRequestType ActionType { get; }
}