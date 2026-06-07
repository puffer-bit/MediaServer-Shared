using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionInfo;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public record SessionInfoRequest(
    int? SessionId) : GenericSessionRequest
{
    public override SessionActionType ActionType => SessionActionType.InfoRequest;
    
    public SessionInfoResponse ToResponse(IDictionary<int, SessionDTO> sessionList, SessionRequestResult result) 
        => new (RequestId, sessionList, result);
}