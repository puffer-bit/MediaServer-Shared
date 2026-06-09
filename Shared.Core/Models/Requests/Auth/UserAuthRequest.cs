using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Auth;

namespace Shared.Models.Requests.Auth
{
    public record UserAuthRequest(
        string? Password, 
        string? UserIdentity) : AuthRequest
    {
        public override AuthActionType ActionType { get; init; } = AuthActionType.Login;
        
        public UserAuthResponse ToResponse(AuthResult authResult, string? userIdentity = null, UserDTO? userDTO = null,
            string? serverMessage = null)
            => new(RequestId, userDTO, userIdentity, authResult, serverMessage);
    }
}
