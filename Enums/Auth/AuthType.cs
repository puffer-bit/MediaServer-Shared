namespace Shared.Enums.Auth;

public enum AuthType
{
    PasswordAuth,
    TwoFactorAuth,
}

public enum AuthResult
{
    Success,
    AuthFailed,
    TwoFactorAuthFailed,
    Banned
}