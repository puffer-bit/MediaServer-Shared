using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests
{
    public class ErrorSessionRequestModel
    {
        public SessionRequestType Type => SessionRequestType.Undefined;

        public ErrorSessionRequestModel()
        {
            
        }
    }
}
