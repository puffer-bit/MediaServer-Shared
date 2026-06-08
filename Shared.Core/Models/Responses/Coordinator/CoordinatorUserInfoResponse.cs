using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.Coordinator;

namespace Shared.Models.Responses.Users;

public record CoordinatorUserInfoResponse(
    string RequestId,
    IDictionary<int, UserDTO> UserList, 
    UsersRequestResult Result) : CoordinatorResponse;