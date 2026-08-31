using Shared.Enums;
using Shared.Models.Responses.SessionActions.HybridSession;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Requests.SessionActions.HybridSession;

public record HybridSessionConnectTransportRequest(
    int SessionId) : HybridSessionRequest
{
    public override HybridSessionActionType ActionType => HybridSessionActionType.ConnectTransport;

    public required DTLSParameters DtlsParameters { get; init; }

    public HybridSessionConnectTransportResponse ToResponse(HybridSessionConnectTransportResult result)
        => new(RequestId, result);
}
