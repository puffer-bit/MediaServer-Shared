using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Notifications.SFU;

public abstract record SFUSessionUpdatedNotification(): Notification;

public record SFUSessionInboundAddedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

public record SFUSessionInboundUpdatedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

public record SFUSessionInboundRemovedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

