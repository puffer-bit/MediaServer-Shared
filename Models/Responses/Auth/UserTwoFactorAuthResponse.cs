using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserTwoFactorAuthResponse(
    string RequestId,
    UserDTO? UserDTO,
    AuthResult AuthResult) : IAuthResponse
{
    public AuthType ActionType => AuthType.TwoFactorAuth;
}