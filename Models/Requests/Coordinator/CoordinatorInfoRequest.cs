using Shared.Enums.Coordinator;
using Shared.Models.DTO;
using Shared.Models.Responses.Coordinator;

namespace Shared.Models.Requests.Coordinator;

public record CoordinatorInfoRequest()
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();

    public CoordinatorActionType Type => CoordinatorActionType.InfoRequest;
        
    public CoordinatorInfoResponse ToResponse(
        CoordinatorSessionDTO coordinatorSessionDto) => 
        new (RequestId, coordinatorSessionDto);
}