using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class DeleteSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Delete;
        public DeleteSessionResult? Result { get; set; }

        public DeleteSessionRequestModel()
        {
            
        }
        
        [SetsRequiredMembers]
        public DeleteSessionRequestModel(SessionDTO session)
        {
            Session = session;
        }
        
        [SetsRequiredMembers]
        public DeleteSessionRequestModel(SessionDTO session, DeleteSessionResult result)
        {
            Session = session;
            Result = result;
        }
    }
}
