using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Requests.Coordinator;
using Shared.Models.Responses.Users;

namespace Shared.Models.Requests.Users;

public record CoordinatorUserInfoRequest(
    IList<int> UserIds) : CoordinatorRequest
{
    public override CoordinatorActionType ActionType => CoordinatorActionType.UserInfoRequest;
    
    public CoordinatorUserInfoResponse ToResponse(IDictionary<int, UserDTO> userList, UsersRequestResult result)
        => new(RequestId, userList, result);
}