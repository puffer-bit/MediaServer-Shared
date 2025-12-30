using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class JoinSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Join;
        public JoinSessionResult? Result { get; set; }
        
        public JoinSessionRequestModel()
        {
            
        }
        
        [SetsRequiredMembers]
        public JoinSessionRequestModel(SessionDTO session)
        {
            Session = session;
        }
        
        [SetsRequiredMembers]
        public JoinSessionRequestModel(SessionDTO session, JoinSessionResult result)
        {
            Result = result;
            Session = session;
        }
    }
}
