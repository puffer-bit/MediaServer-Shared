using System.Diagnostics.CodeAnalysis;
using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionActionsRequests;

public class ApproveUserRequestModel
{
    public required string SessionId { get; set; }
    public required string UserTargetId { get; set; }
    public required SessionType SessionType { get; set; }
    public SessionRequestType Type => SessionRequestType.Approve;
    public ApproveUserSessionResult? Result { get; set; }

    public ApproveUserRequestModel(string userTargetId)
    {
        UserTargetId = userTargetId;
    }
                
    [SetsRequiredMembers]
    public ApproveUserRequestModel(string sessionId, string userTargetId)
    {
        SessionId = sessionId;
        UserTargetId = userTargetId;
    }
        
    [SetsRequiredMembers]
    public ApproveUserRequestModel(string sessionId, ApproveUserSessionResult result, string userTargetId)
    {
        SessionId = sessionId;
        Result = result;
        UserTargetId = userTargetId;
    }
}