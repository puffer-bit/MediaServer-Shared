using Shared.Enums;

namespace Shared.Models.Responses;

public record ActionFailedResponse(string RequestId) : IResponse;