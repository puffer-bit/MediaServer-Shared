using Shared.Enums;

namespace Shared.Models.Responses.Sessions;

public interface ISessionResponse
{
    string RequestId { get; init; }
    SessionRequestType Type { get; }
}