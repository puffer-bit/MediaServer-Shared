using Shared.Enums;

namespace Shared.Models.Responses;

public interface IResponse
{
    string RequestId { get; }
}