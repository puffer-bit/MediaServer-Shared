using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public class BanFromSessionRequestModel : IUserSessionRequestModel
{
    public string? PeerId { get; set; }
    public required SessionDTO Session { get; set; }
    public SessionRequestType Type => SessionRequestType.Ban;
    public BanFromSessionResult? Result { get; set; }

    public BanFromSessionRequestModel()
    {
            
    }
                
    [SetsRequiredMembers]
    public BanFromSessionRequestModel(SessionDTO session)
    {
        Session = session;
    }
        
    [SetsRequiredMembers]
    public BanFromSessionRequestModel(SessionDTO session, BanFromSessionResult result)
    {
        Session = session;
        Result = result;
    }
}