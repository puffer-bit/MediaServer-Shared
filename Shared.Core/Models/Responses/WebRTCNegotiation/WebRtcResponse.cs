namespace Shared.Models.Responses.WebRTCNegotiation;

public abstract record WebRtcResponse(Guid RequestId) : Response(RequestId)
{
    
}