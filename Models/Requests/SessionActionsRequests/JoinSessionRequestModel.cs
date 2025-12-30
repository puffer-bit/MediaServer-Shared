using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class JoinSessionRequestModel
    {
        public required string SessionId { get; set; }
        public required SessionType SessionType { get; set; }
        public SessionRequestType Type => SessionRequestType.Join;
        public JoinSessionResult? Result { get; set; }
        
        public JoinSessionRequestModel()
        {
            
        }
        
        [SetsRequiredMembers]
        public JoinSessionRequestModel(string sessionId)
        {
            SessionId = sessionId;
        }
        
        [SetsRequiredMembers]
        public JoinSessionRequestModel(string sessionId, JoinSessionResult result)
        {
            Result = result;
            SessionId = sessionId;
        }
    }
}
