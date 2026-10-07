using Shared.Models.DataTransferObjects;
using Shared.Models.DataTransferObjects.ChatSession.Messages;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record ChatSessionUpdatedNotification : Notification;

public record ChatSessionMessageAddedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification;

public record ChatSessionMessageEditedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification;

public record ChatSessionMessageDeletedNotification(int ChatId, int MessageId)
    : ChatSessionUpdatedNotification;

public record ChatSessionUserTypingNotification(int ChatId, int UserId)
    : ChatSessionUpdatedNotification;
