using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    string RequestId,
    UserDTO? UserDTO,
    CoordinatorSessionDTO? CoordinatorSessionDTO,
    AuthResult AuthResult) : IResponse;