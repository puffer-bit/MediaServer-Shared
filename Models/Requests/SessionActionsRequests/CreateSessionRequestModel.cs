using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class CreateSessionRequestModel
    {
        public required string SessionId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Create;
        public CreateSessionResult? Result { get; set; }

        public CreateSessionRequestModel()
        {
            
        }
        
        [SetsRequiredMembers]
        public CreateSessionRequestModel(SessionDTO session)
        {
            Session = session;
            SessionId = session.Id;
        }
        
        [SetsRequiredMembers]
        public CreateSessionRequestModel(SessionDTO session, CreateSessionResult result)
        {
            Session = session;
            SessionId = session.Id;
            Result = result;
        }
    }
}
