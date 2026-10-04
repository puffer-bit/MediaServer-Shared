namespace Shared.Models.Responses.SFU;

public abstract record SFUResponse(Guid RequestId) : Response(RequestId);

