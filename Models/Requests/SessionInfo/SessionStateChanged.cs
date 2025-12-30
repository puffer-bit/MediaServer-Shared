using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionInfo;

public class SessionStateChangedModel
{
    public required SessionDTO Session { get; set; }
    public required SessionStateChangedType Type { get; set; }

    [SetsRequiredMembers]
    public SessionStateChangedModel(SessionDTO session, SessionStateChangedType type)
    {
        Session = session;
        Type = type;
    }
}