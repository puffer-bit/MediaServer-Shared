using Shared.Enums;
using Shared.Models.DTO;

namespace Shared.Models.Requests.SessionInfo;

public abstract record SessionUpdatedEvent(SessionStateChangedType Type);

public record ParticipantJoinedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserJoined);

public record ParticipantConnectedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserConnected);
    
public record ParticipantLeavedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserLeaved);

public record ParticipantDisconnectedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserDisconnected);

public record ParticipantKickedResponse(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserKicked);

public record ParticipantBannedResponse(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserBanned);

public record ParticipantApprovedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserApproved);

public record ParticipantRejectedResponse(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.UserRejected);

public record HostJoinedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.HostJoined);

public record HostConnectedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.HostConnected);
    
public record HostLeavedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.HostJoined);

public record HostDisconnectedResponse(string SessionId, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.HostDisconnected);

public record HostKickedResponse(string SessionId, string Reason, UserDTO User)
    : SessionUpdatedEvent(SessionStateChangedType.HostKicked);
