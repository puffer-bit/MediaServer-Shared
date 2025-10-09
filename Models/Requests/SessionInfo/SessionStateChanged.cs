using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.SessionInfo;

public class SessionStateChanged
{
    public required SessionDTO Session { get; set; }
    public required SessionStateChangedType Type { get; set; }

    [SetsRequiredMembers]
    public SessionStateChanged(SessionDTO session, SessionStateChangedType type)
    {
        Session = session;
        Type = type;
    }
}