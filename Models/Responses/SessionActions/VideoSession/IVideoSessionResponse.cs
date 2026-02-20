using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public interface IVideoSessionResponse : IResponse
{
    SessionRequestType Type { get; }
}