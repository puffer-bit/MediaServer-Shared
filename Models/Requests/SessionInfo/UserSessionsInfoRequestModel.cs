using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.SessionInfo
{
    public class UserSessionsInfoRequestModel
    {
        public string? RoomId { get; set; }
        public SessionType? SessionType { get; set; }
        public SessionRequestResult? Result { get; set; }
        public Dictionary<string, SessionDTO> SessionsList { get; set; } = new();
        public required bool IsAllSessionsRequested { get; set; }

        [SetsRequiredMembers]
        public UserSessionsInfoRequestModel(bool isAllSessionsRequested)
        {
            IsAllSessionsRequested = isAllSessionsRequested;
        }
        
        public void AddSession(string roomId, SessionDTO session)
        {
            SessionsList.Add(roomId, session);
        }

        public void AddSessions(IDictionary<string, SessionDTO> sessions)
        {
            foreach (var session in sessions)
            {
                SessionsList.Add(session.Key, session.Value);
            }
        }
    }
}
