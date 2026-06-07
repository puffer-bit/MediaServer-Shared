using Shared.Enums;
using Shared.Enums.Auth;

namespace Shared.Models.Responses.Auth;

public record AuthResponse
{
    public virtual AuthActionType ActionType { get; init; }
}