using Shared.Enums;

namespace Shared.Models.Requests.SessionActionsRequests;

public interface IUserSessionRequestModel
{
    SessionDTO Session { get; set; }
    SessionRequestType Type { get; }
}