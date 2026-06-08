using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.Coordinator;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorInfoRequest() : CoordinatorRequest
{
    public override CoordinatorActionType ActionType { get; init; } = CoordinatorActionType.InfoRequest;
        
    public CoordinatorInfoResponse ToResponse(
        CoordinatorSessionDTO coordinatorSessionDto) => 
        new (RequestId, coordinatorSessionDto);
}