using Shared.Enums;
using Shared.Models.Media;

namespace Shared.Models.Responses.SessionActions.HybridSession;

public record HybridSessionStartScreenShareResponse(
    Guid RequestId,
    StartScreenShareResult Result,
    Outbound? Outbound) : HybridSessionResponse(RequestId);
