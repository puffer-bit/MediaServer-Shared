using Shared.Enums;

namespace Shared.Models.Requests.SessionActions;

public interface ICreateSessionData
{
    SessionType Type { get; }
}