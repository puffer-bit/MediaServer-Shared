using Shared.Enums;
using Shared.Models.DataTransferObjects;

namespace Shared.Models.Responses.SessionActions.Generic;

public record SessionInfoResponse(
    Guid RequestId,
    IList<SessionDTO> SessionsList,
    SessionRequestResult Result) : GenericSessionResponse(RequestId)
{
    public override SessionActionType ActionType { get; init; } = SessionActionType.InfoRequest;
}