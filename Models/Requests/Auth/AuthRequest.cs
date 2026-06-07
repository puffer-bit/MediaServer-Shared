using Shared.Enums;

namespace Shared.Models.Requests.Auth;

public abstract record AuthRequest : Request
{
    public abstract AuthActionType ActionType { get; init; }
}