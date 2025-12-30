using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class LeaveSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Leave;
        public LeaveSessionResult? Result { get; set; }

        public LeaveSessionRequestModel()
        {
            
        }
                
        [SetsRequiredMembers]
        public LeaveSessionRequestModel(SessionDTO session)
        {
            Session = session;
        }
        
        [SetsRequiredMembers]
        public LeaveSessionRequestModel(SessionDTO session, LeaveSessionResult result)
        {
            Session = session;
            Result = result;
        }
    }
}
