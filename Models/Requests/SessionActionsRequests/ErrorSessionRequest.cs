using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public class ErrorSessionRequest
    {
        public SessionRequestType Type => SessionRequestType.Undefined;

        public ErrorSessionRequest()
        {
            
        }
    }
}
