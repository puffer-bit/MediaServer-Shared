using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    [method: SetsRequiredMembers]
    public class UndefinedSessionRequestModel : IUserSessionRequestModel
    {
        public string? PeerId { get; set; }
        public required SessionDTO Session { get; set; }
        public SessionRequestType Type => SessionRequestType.Undefined;

        public UndefinedSessionRequestModel()
        {
            
        }
    }
}
