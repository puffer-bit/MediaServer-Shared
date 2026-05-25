using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.DTO.TextChat.Messages;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record TextChatUpdatedNotification(TextChatStateChangedType Type);

public record TextChaMessageAddedNotification(int ChatId, ChatMessageDTO Message)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageAdded);

public record TextChaMessageEditedNotification(int ChatId, ChatMessageDTO Message)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageEdited);

public record TextChaMessageDeletedNotification(int ChatId, int MessageId)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageDeleted);

public record TextChatUserTypingNotification(int ChatId, UserDTO User)
    : TextChatUpdatedNotification(TextChatStateChangedType.UserTyping);

