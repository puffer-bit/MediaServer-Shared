namespace Shared.Models.Notifications;

public abstract record Notification() : BaseMessageData
{
    public override BaseMessageDataType DataType { get; init; } = BaseMessageDataType.Notification;
}