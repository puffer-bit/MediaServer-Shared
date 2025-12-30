using System.Diagnostics.CodeAnalysis;
using Shared.Enums;

namespace Shared.Models.Requests.WebRTCNegotiation
{
    public class WebRTCNegotiationModel
    {
        public WebRTCNegotiationType Type { get; set; }
        public required string? PeerId { get; set; }
        public required string RoomId { get; set; }
        public object? Data { get; set; }
        public WebRTCNegotiationResult Result { get; set; }
        public WebRTCNegotiationModel()
        {

        }

        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationType type, string? peerId, string roomId, object? data)
        {
            Type = type;
            PeerId = peerId;
            RoomId = roomId;
            Data = data;
        }
        
        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationModel request)
        {
            Type = request.Type;
            PeerId = request.PeerId;
            RoomId = request.RoomId;
            Data = request.Data;
        }
        
        [SetsRequiredMembers]
        public WebRTCNegotiationModel(WebRTCNegotiationModel request, WebRTCNegotiationResult result)
        {
            Type = request.Type;
            PeerId = request.PeerId;
            RoomId = request.RoomId;
            Data = request.Data;
            Result = result;
        }
    }
}
