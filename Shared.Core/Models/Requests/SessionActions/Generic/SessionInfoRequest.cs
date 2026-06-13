using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SessionActions.Generic;

namespace Shared.Models.Requests.SessionActions.Generic;

public record SessionInfoRequest(
    int? SessionId) : GenericSessionRequest
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.InfoRequest;
    
    public SessionInfoResponse ToResponse(IList<SessionDTO> sessionList, SessionRequestResult result) 
        => new (RequestId, sessionList, result);
}