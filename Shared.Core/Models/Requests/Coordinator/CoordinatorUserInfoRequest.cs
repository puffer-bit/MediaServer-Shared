using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Coordinator;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorUserInfoRequest(
    IList<int> UserIds) : CoordinatorRequest
{
    public override CoordinatorActionType ActionType { get; init; } = CoordinatorActionType.UserInfoRequest;
    
    public CoordinatorUserInfoResponse ToResponse(IDictionary<int, UserDTO> userList, UsersRequestResult result)
        => new(RequestId, userList, result);
}