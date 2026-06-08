namespace Shared.Models;

public abstract record BaseMessageData
{
    public abstract BaseMessageDataType DataType { get; init; }
}

public enum BaseMessageDataType
{
    Request,
    Response,
    Notification,
}