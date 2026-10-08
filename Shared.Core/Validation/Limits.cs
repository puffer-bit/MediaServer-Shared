namespace Shared.Validation;

/// <summary>
/// Size limits of request fields, shared so the client can check input before sending and the
/// server rejects the same things. String limits match the server database columns.
/// </summary>
public static class Limits
{
    public const int UserIdentityMaxLength = 37;
    public const int PasswordMaxLength = 128;
    public const int UserIdsMaxCount = 100;
    public const int UsernameMaxLength = 32;

    public const int SessionNameMaxLength = 50;
    public const int SessionCapacityMin = 1;
    public const int SessionCapacityMax = 100;
    public const int SessionDescriptionMaxLength = 500;
    public const int UrlMaxLength = 2048;
    public const int VideoBitrateMinKbps = 100;
    public const int VideoBitrateMaxKbps = 20_000;

    public const int ReasonMaxLength = 200;

    public const int ChatTextMaxLength = 4000;
    public const int ChatHistoryMaxTake = 100;
    public const int ChatAttachmentsMaxCount = 10;
    public static readonly TimeSpan ChatMessageMaxDelay = TimeSpan.FromDays(30);
    public static readonly TimeSpan ChatMessageMaxLifetime = TimeSpan.FromDays(365);

    public const int ClientEpochMaxLength = 36;
    public const int DtlsFingerprintsMaxCount = 5;
    public const int DtlsAlgorithmMaxLength = 16;

    // sha-512 is 64 bytes written as colon-separated hex pairs
    public const int DtlsFingerprintMaxLength = 64 * 3 - 1;

    public const int SdpMaxLength = 64 * 1024;
}
