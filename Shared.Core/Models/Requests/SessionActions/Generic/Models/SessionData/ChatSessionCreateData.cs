using Shared.Enums;
using Shared.Models.Requests.SessionActions.Generic.Models.SessionData;

namespace Shared.Models.Requests.SessionActions.Generic.Models;

public record ChatSessionCreateData(
    string? Description = null,
    string? IconPath = null,
    bool IsEncrypted = false,
    bool IsAttachmentsAllowed = true,
    bool IsVoiceMessageAllowed = true,
    bool IsVideoMessagesAllowed = true,
    bool IsDelayedMessagesAllowed = true
) : CreateSessionData
{
    public override SessionType SessionType { get; init; } = SessionType.Chat;
}