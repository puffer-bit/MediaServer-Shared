using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Coordinator;

public record CoordinatorInfoResponse(
    string RequestId,
    CoordinatorSessionDTO CoordinatorSessionDto) : CoordinatorResponse
{
    public override CoordinatorActionType ActionType => CoordinatorActionType.InfoRequest;
}