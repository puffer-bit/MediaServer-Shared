using Shared.Enums;

namespace Shared.Models.Responses.SessionActions;

public interface ISessionResponse : IResponse
{
    SessionRequestType Type { get; }
}