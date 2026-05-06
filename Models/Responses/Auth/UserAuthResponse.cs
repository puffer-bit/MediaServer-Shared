using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    string RequestId,
    UserDTO? UserDTO,
    string UserIdentity,
    CoordinatorSessionDTO? CoordinatorSessionDTO,
    AuthResult AuthResult,
    string? ServerMessage) : IAuthResponse
{
    public AuthType Type => AuthType.PasswordAuth;
}