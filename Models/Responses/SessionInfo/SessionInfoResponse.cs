using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionInfo;

public record SessionInfoResponse(
    string RequestId,
    IDictionary<int, SessionDTO> SessionsList,
    SessionRequestResult Result) : IResponse;