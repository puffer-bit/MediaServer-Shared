using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.SessionActionsRequests;

public class RejectUserRequestModel : IUserSessionRequestModel
{
    public string? PeerId { get; set; }
    public required SessionDTO Session { get; set; }
    public SessionRequestType Type => SessionRequestType.Reject;
    public RejectUserSessionResult? Result { get; set; }

    public RejectUserRequestModel()
    {
            
    }
                
    [SetsRequiredMembers]
    public RejectUserRequestModel(SessionDTO session)
    {
        Session = session;
    }
        
    [SetsRequiredMembers]
    public RejectUserRequestModel(SessionDTO session, RejectUserSessionResult result)
    {
        Session = session;
        Result = result;
    }
}