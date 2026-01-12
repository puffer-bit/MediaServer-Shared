using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    UserDTO? UserDTO,
    CoordinatorSessionDTO? CoordinatorSessionDTO,
    AuthResult AuthResult);