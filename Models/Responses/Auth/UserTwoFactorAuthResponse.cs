using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserTwoFactorAuthResponse(
    string RequestId,
    UserDTO? UserDTO,
    CoordinatorSessionDTO? CoordinatorSessionDTO,
    AuthResult AuthResult) : IAuthResponse
{
    public AuthType Type => AuthType.TwoFactorAuth;
}