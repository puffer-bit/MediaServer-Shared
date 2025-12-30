using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public class BanFromSessionRequestModel
{
    public required string SessionId { get; set; }
    public required string UserTargetId { get; set; }
    public required SessionType SessionType { get; set; }
    public SessionRequestType Type => SessionRequestType.Ban;
    public string? Reason { get; set; }
    public BanFromSessionResult? Result { get; set; }

    public BanFromSessionRequestModel(string userTargetId)
    {
        UserTargetId = userTargetId;
    }
                
    [SetsRequiredMembers]
    public BanFromSessionRequestModel(string sessionId, string userTargetId)
    {
        SessionId = sessionId;
        UserTargetId = userTargetId;
    }
        
    [SetsRequiredMembers]
    public BanFromSessionRequestModel(string sessionId, BanFromSessionResult result, string userTargetId)
    {
        SessionId = sessionId;
        Result = result;
        UserTargetId = userTargetId;
    }
}