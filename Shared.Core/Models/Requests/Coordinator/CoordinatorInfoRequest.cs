using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.Coordinator;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorInfoRequest() : CoordinatorRequest
{
    public override CoordinatorActionType ActionType => CoordinatorActionType.InfoRequest;
        
    public CoordinatorInfoResponse ToResponse(
        CoordinatorSessionDTO coordinatorSessionDto) => 
        new (RequestId, coordinatorSessionDto);
}