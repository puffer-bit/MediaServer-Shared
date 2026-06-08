using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionActions.VideoSession;

namespace Shared.Models.Responses.SessionInfo;

public record SessionInfoResponse(
    string RequestId,
    IDictionary<int, SessionDTO> SessionsList,
    SessionRequestResult Result) : GenericSessionResponse
{
    public override SessionActionType ActionType => SessionActionType.InfoRequest;
}