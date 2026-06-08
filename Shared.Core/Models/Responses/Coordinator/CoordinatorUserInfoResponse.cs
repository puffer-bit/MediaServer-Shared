using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Responses.Coordinator;

public record CoordinatorUserInfoResponse(
    string RequestId,
    IDictionary<int, UserDTO> UserList, 
    UsersRequestResult Result) : CoordinatorResponse
{
    public override CoordinatorActionType ActionType { get; init; } = CoordinatorActionType.InfoRequest;
}