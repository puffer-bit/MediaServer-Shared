using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class CreateSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
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
        }
        
        [SetsRequiredMembers]
        public CreateSessionRequestModel(SessionDTO session, CreateSessionResult result)
        {
            Session = session;
            Result = result;
        }
    }
}
