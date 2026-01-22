using Shared.Enums.Auth;

namespace Shared.Models.Responses.Auth;

public interface IAuthResponse : IResponse
{
    AuthType Type { get; }
}