using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class KickFromSessionRequestModel
    {
        public required string SessionId { get; set; }
        public required string UserTargetId { get; set; }
        public required SessionType SessionType { get; set; }
        public SessionRequestType Type => SessionRequestType.Kick;
        public string? Reason { get; set; }
        public LeaveSessionResult? Result { get; set; }

        public KickFromSessionRequestModel(string userTargetId)
        {
            UserTargetId = userTargetId;
        }
                
        [SetsRequiredMembers]
        public KickFromSessionRequestModel(string sessionId, string userTargetId)
        {
            SessionId = sessionId;
            UserTargetId = userTargetId;
        }
        
        [SetsRequiredMembers]
        public KickFromSessionRequestModel(string sessionId, LeaveSessionResult result, string userTargetId)
        {
            SessionId = sessionId;
            Result = result;
            UserTargetId = userTargetId;
        }
    }
}
