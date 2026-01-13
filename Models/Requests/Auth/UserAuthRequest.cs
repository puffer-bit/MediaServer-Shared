using Shared.Enums.Auth;
using Shared.Models.DTO;
using Shared.Models.Responses.Auth;

namespace Shared.Models.Requests.Auth
{
    public record UserAuthRequest(string? Password, string? UserIdentity)
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        
        public UserAuthResponse ToResponse(AuthResult authResult, UserDTO? userDTO = null, CoordinatorSessionDTO? coordinatorSessionDTO = null )
            => new(RequestId, userDTO, coordinatorSessionDTO, authResult);
    }
}
