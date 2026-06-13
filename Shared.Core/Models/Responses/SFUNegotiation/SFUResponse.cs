namespace Shared.Models.Responses.SFUNegotiation;

public abstract record SFUResponse(Guid RequestId) : Response(RequestId);

