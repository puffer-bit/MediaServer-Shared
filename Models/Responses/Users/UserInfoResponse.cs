using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Users;

public record UserInfoResponse(
    IDictionary<string, UserDTO> UserList, 
    UsersRequestResult Result);