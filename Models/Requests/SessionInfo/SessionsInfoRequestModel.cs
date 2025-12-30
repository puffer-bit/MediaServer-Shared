using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionInfo
{
    public class SessionsInfoRequestModel
    {
        public string? SessionId { get; set; }
        public SessionRequestResult? Result { get; set; }
        public Dictionary<string, SessionDTO> SessionsList { get; set; } = new();
        
        public void AddSession(string sessionId, SessionDTO session)
        {
            SessionsList.Add(sessionId, session);
        }

        public void AddSessions(IReadOnlyDictionary<string, SessionDTO> sessions)
        {
            foreach (var session in sessions)
            {
                SessionsList.Add(session.Key, session.Value);
            }
        }
    }
}
