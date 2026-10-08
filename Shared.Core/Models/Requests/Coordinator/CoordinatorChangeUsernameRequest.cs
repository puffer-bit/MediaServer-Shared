using System.ComponentModel.DataAnnotations;
using Shared.Enums.User;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Coordinator;
using Shared.Validation;

namespace Shared.Models.Requests.Coordinator;

/// <summary>Renames the sender; the name must not be taken by another user.</summary>
public record CoordinatorChangeUsernameRequest(
    [property: Required, NotBlank, StringLength(Limits.UsernameMaxLength), NoControlCharacters] string Username) : CoordinatorRequest
{
    public CoordinatorChangeUsernameResponse ToResponse(ChangeUsernameResult result, UserDTO? user = null)
        => new(RequestId, result, user);
}
