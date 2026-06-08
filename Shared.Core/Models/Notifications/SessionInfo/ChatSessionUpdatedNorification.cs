using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.DTO.TextChat.Messages;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record ChatSessionUpdatedNotification(TextChatStateChangedType Type): Notification;

public record ChaMessageAddedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification(TextChatStateChangedType.MessageAdded);

public record ChaMessageEditedNotification(int ChatId, ChatMessageDTO Message)
    : ChatSessionUpdatedNotification(TextChatStateChangedType.MessageEdited);

public record ChaMessageDeletedNotification(int ChatId, int MessageId)
    : ChatSessionUpdatedNotification(TextChatStateChangedType.MessageDeleted);

public record ChatSessionUserTypingNotification(int ChatId, UserDTO User)
    : ChatSessionUpdatedNotification(TextChatStateChangedType.UserTyping);

