using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class DeleteSessionRequestModel
    {
        public required string SessionId { get; set; }
        public required SessionType SessionType { get; set; }
        public SessionRequestType Type => SessionRequestType.Delete;
        public DeleteSessionResult? Result { get; set; }

        public DeleteSessionRequestModel()
        {
            
        }
        
        [SetsRequiredMembers]
        public DeleteSessionRequestModel(string sessionId)
        {
            SessionId = sessionId;
        }
        
        [SetsRequiredMembers]
        public DeleteSessionRequestModel(string sessionId, DeleteSessionResult result)
        {
            SessionId = sessionId;
            Result = result;
        }
    }
}
