using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.Responses.SFUNegotiation;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record SFUSessionUpdatedNotification(): Notification;

public record SFUSessionInboundAddedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

public record SFUSessionInboundUpdatedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

public record SFUSessionInboundRemovedNotification(int SessionId, Inbound Inbound)
    : SFUSessionUpdatedNotification();

