using Shared.Enums;

namespace Shared.Models.Responses;

public record FailedResponse(
    Guid RequestId,
    string? Message)
    : Response;