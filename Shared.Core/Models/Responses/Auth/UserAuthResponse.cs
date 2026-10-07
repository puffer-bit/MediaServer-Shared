using Shared.Enums.Auth;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Responses.Auth;

public record UserAuthResponse(
    Guid RequestId,
    UserDTO? UserDTO,
    string? UserIdentity,
    AuthResult AuthResult,
    string? ServerMessage) : AuthResponse(RequestId);
