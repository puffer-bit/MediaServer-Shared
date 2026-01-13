using Shared.Enums;

namespace Shared.Models.Responses.Sessions;

public interface ISessionResponse : IResponse
{
    SessionRequestType Type { get; }
}