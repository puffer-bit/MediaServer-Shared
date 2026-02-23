using Shared.Enums;
using Shared.Models.DTO;
using Shared.Models.DTO.TextChat.Messages;

namespace Shared.Models.Notifications.SessionInfo;

public abstract record TextChatUpdatedNotification(TextChatStateChangedType Type);

public record TextChaMessageAddedNotification(string ChatId, ChatMessageDTO Message)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageAdded);

public record TextChaMessageEditedNotification(string ChatId, ChatMessageDTO Message)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageEdited);

public record TextChaMessageDeletedNotification(string ChatId, string MessageId)
    : TextChatUpdatedNotification(TextChatStateChangedType.MessageDeleted);

public record TextChatUserTypingNotification(string ChatId, UserDTO User)
    : TextChatUpdatedNotification(TextChatStateChangedType.UserTyping);

