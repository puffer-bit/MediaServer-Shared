using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public interface IUserSessionRequestModel
{
    SessionDTO Session { get; set; }
    SessionRequestType Type { get; }
}