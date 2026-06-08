using Shared.Enums;

namespace Shared.Models.Responses;

public abstract record Response : BaseMessageData
{
    public override BaseMessageDataType DataType { get; init; } = BaseMessageDataType.Response;
    public string RequestId { get; init; } = null!;
}