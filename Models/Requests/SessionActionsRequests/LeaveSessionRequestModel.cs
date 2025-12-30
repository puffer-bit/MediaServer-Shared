using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class LeaveSessionRequestModel
    {
        public required string SessionId { get; set; }
        public required SessionType SessionType { get; set; }
        public SessionRequestType Type => SessionRequestType.Leave;
        public LeaveSessionResult? Result { get; set; }

        public LeaveSessionRequestModel()
        {
            
        }
                
        [SetsRequiredMembers]
        public LeaveSessionRequestModel(string sessionId)
        {
            SessionId = sessionId;
        }
        
        [SetsRequiredMembers]
        public LeaveSessionRequestModel(string sessionId, LeaveSessionResult result)
        {
            SessionId = sessionId;
            Result = result;
        }
    }
}
