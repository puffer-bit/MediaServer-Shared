using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class KickFromSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Kick;
        public LeaveSessionResult? Result { get; set; }

        public KickFromSessionRequestModel()
        {
            
        }
                
        [SetsRequiredMembers]
        public KickFromSessionRequestModel(SessionDTO session)
        {
            Session = session;
        }
        
        [SetsRequiredMembers]
        public KickFromSessionRequestModel(SessionDTO session, LeaveSessionResult result)
        {
            Session = session;
            Result = result;
        }
    }
}
