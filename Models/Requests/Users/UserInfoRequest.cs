using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.Users;

namespace Shared.Models.Requests.Users;

public record UserInfoRequest(IList<string> UserIds)
{
    public string RequestId { get; } = Guid.NewGuid().ToString();

    public UserInfoResponse ToResponse(IDictionary<string, UserDTO> userList, UsersRequestResult result)
        => new(RequestId, userList, result);
}