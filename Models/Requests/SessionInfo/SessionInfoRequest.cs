using System.Collections.Generic;
using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.Responses.SessionInfo;

namespace Shared.Models.Requests.SessionInfo
{
    public record SessionInfoRequest(string? SessionId)
    {
        public string RequestId { get; init; } = Guid.NewGuid().ToString();
        
        public SessionInfoResponse ToResponse(IDictionary<string, SessionDTO> sessionList, SessionRequestResult result) 
            => new (RequestId, sessionList, result);
    }
}
