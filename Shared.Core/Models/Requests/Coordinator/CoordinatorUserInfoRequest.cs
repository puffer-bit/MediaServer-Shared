using System.ComponentModel.DataAnnotations;
using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Coordinator;
using Shared.Validation;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorUserInfoRequest(
    [property: Required, Length(1, Limits.UserIdsMaxCount)] IList<int> UserIds) : CoordinatorRequest
{
    public override CoordinatorActionType ActionType { get; init; } = CoordinatorActionType.UserInfoRequest;

    public CoordinatorUserInfoResponse ToResponse(IDictionary<int, UserDTO> userList, UsersRequestResult result)
        => new(RequestId, userList, result);
}
