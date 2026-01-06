using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    UserDTO? UserDTO,
    AuthResult AuthResult);