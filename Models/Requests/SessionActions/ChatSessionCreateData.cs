using Shared.Enums;
using Shared.Models.Requests.SessionActions.VideoSession;

namespace Shared.Models.Requests.SessionActions;

public record ChatSessionCreateData(
    string? Description = null,
    string? IconPath = null,
    bool IsEncrypted = false,
    bool IsAttachmentsAllowed = true,
    bool IsVoiceMessageAllowed = true,
    bool IsVideoMessagesAllowed = true,
    bool IsDelayedMessagesAllowed = true
) : ICreateSessionData
{
    public SessionType Type => SessionType.Chat;
}