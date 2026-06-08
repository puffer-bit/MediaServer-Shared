using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Responses.Coordinator;

public record CoordinatorInfoResponse(
    string RequestId,
    CoordinatorSessionDTO CoordinatorSessionDto) : CoordinatorResponse
{
    public override CoordinatorActionType ActionType { get; init; } = CoordinatorActionType.InfoRequest;
}