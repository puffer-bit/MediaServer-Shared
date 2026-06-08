using Shared.Enums;
using Shared.Models.DataTransferObjects;
using Shared.Models.DataTransferObjects.TextChat.Messages;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record ChatSessionUpdatedNotification(ChatSessionStateChangedType NotificationType): Notification;

public record ChatSessionMessageAddedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification(ChatSessionStateChangedType.MessageAdded);

public record ChatSessionMessageEditedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification(ChatSessionStateChangedType.MessageEdited);

public record ChatSessionMessageDeletedNotification(int ChatId, int MessageId)
    : ChatSessionUpdatedNotification(ChatSessionStateChangedType.MessageDeleted);

public record ChatSessionUserTypingNotification(int ChatId, UserDTO User)
    : ChatSessionUpdatedNotification(ChatSessionStateChangedType.UserTyping);

