namespace Shared.Models;

public abstract record BaseMessageData()
{
    public abstract BaseMessageType Type { get; init; }
}

public enum BaseMessageType
{
    Request,
    Response,
    Notification,
}