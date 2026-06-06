using Shared.Enums.Coordinator;
using Shared.Models.DTO;

namespace Shared.Models.Responses.Coordinator;

public record CoordinatorInfoResponse(
    string RequestId,
    CoordinatorSessionDTO CoordinatorSessionDto) : IResponse
{
    public CoordinatorActionType ActionType => CoordinatorActionType.InfoRequest;
}