using Shared.Enums;

namespace Shared.Models.Responses.Coordinator;

public record RegisterPushTokenResponse(
    Guid RequestId,
    PushTokenResult Result) : CoordinatorResponse(RequestId);
