using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    string RequestId,
    UserDTO? UserDTO,
    string UserIdentity,
    AuthResult AuthResult,
    string? ServerMessage) : AuthResponse
{
    public override AuthActionType ActionType => AuthActionType.Login;
}