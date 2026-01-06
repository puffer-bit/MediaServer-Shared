using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Responses.SessionInfo;

public record SessionInfoResponse(
    IDictionary<string, SessionDTO> SessionsList,
    SessionRequestResult Result);