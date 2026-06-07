using Shared.Enums;

namespace Shared.Models.Responses;

public record FailedResponse(
    string RequestId,
    string? Message) 
    : Response;