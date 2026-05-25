using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Users;

public record UserInfoResponse(
    string RequestId,
    IDictionary<int, UserDTO> UserList, 
    UsersRequestResult Result) : IResponse;