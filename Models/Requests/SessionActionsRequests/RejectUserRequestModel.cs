using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public class RejectUserRequestModel
{
    public required string SessionId { get; set; }
    public required string UserTargetId { get; set; }
    public required SessionType SessionType { get; set; }
    public SessionRequestType Type => SessionRequestType.Reject;
    public string? Reason { get; set; }
    public RejectUserSessionResult? Result { get; set; }

    public RejectUserRequestModel(string userTargetId)
    {
        UserTargetId = userTargetId;
    }
                
    [SetsRequiredMembers]
    public RejectUserRequestModel(string sessionId, string userTargetId)
    {
        SessionId = sessionId;
        UserTargetId = userTargetId;
    }
        
    [SetsRequiredMembers]
    public RejectUserRequestModel(string sessionId, RejectUserSessionResult result, string userTargetId)
    {
        SessionId = sessionId;
        Result = result;
        UserTargetId = userTargetId;
    }
}