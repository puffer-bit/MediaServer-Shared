using System.ComponentModel.DataAnnotations;
using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Auth;
using Shared.Validation;

namespace Shared.Models.Requests.Auth;

public record UserAuthRequest(
    [property: StringLength(Limits.PasswordMaxLength)] string? Password,
    [property: StringLength(Limits.UserIdentityMaxLength), NoControlCharacters] string? UserIdentity) : AuthRequest
{
    public override AuthActionType ActionType { get; init; } = AuthActionType.Login;

    public UserAuthResponse ToResponse(AuthResult authResult, string? userIdentity = null, UserDTO? userDTO = null,
        string? serverMessage = null)
        => new(RequestId, userDTO, userIdentity, authResult, serverMessage);
}
