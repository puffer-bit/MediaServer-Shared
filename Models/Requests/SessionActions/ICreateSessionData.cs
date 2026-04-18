using Shared.Enums;

namespace Shared.Models.Requests.SessionActions.VideoSession;

public interface ICreateSessionData
{
    SessionType Type { get; }
}