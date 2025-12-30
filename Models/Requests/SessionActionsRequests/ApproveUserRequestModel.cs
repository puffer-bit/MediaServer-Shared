using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public class ApproveUserRequestModel : IUserSessionRequestModel
{
    public string? PeerId { get; set; }
    public required SessionDTO Session { get; set; }
    public SessionRequestType Type => SessionRequestType.Approve;
    public ApproveUserSessionResult? Result { get; set; }

    public ApproveUserRequestModel()
    {
            
    }
                
    [SetsRequiredMembers]
    public ApproveUserRequestModel(SessionDTO session)
    {
        Session = session;
    }
        
    [SetsRequiredMembers]
    public ApproveUserRequestModel(SessionDTO session, ApproveUserSessionResult result)
    {
        Session = session;
        Result = result;
    }
}