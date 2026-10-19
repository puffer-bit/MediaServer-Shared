namespace Shared.Enums.Auth;

public enum AuthResult
{
    Success,
    AuthFailed,
    Banned,
    SecondStageRequeried
}

public enum SecondStageAuthType
{
    FIDO2,
    TwoFactor,
    Password
}
