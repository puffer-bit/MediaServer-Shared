using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public class WebRTCNegotiationModel
    {
        public WebRTCNegotiationType Type { get; set; }
        public string SessionId { get; set; }
        public object? Data { get; set; }
        public WebRTCNegotiationResult Result { get; set; }
        
        public WebRTCNegotiationModel()
        {

        }

        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationType type, string sessionId, object? data)
        {
            Type = type;
            SessionId = sessionId;
            Data = data;
        }
        
        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationModel request)
        {
            Type = request.Type;
            SessionId = request.SessionId;
            Data = request.Data;
        }
        
        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationModel request, WebRTCNegotiationResult result)
        {
            Type = request.Type;
            SessionId = request.SessionId;
            Data = request.Data;
            Result = result;
        }
    }
}
