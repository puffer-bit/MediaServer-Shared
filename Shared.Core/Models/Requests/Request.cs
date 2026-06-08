namespace Shared.Models.Requests;

public abstract record Request() : BaseMessageData
{
    public override BaseMessageDataType DataType { get; init; } = BaseMessageDataType.Request;
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
}