using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Shared.Validation;

/// <summary>An id that refers to an existing entity: strictly positive.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class EntityIdAttribute() : RangeAttribute(1, int.MaxValue);

/// <summary>The value is one of the declared members of its enum.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class DefinedEnumAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) =>
        value == null || (value.GetType().IsEnum && Enum.IsDefined(value.GetType(), value));

    public override string FormatErrorMessage(string name) => $"{name} is not a defined value.";
}

/// <summary>
/// Rejects control characters, which have no place in names and reasons and can break logs or
/// the UI. Text that may span lines allows line breaks and tabs.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class NoControlCharactersAttribute(bool allowLineBreaks = false) : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is not string text)
            return true;

        foreach (var c in text)
        {
            if (!char.IsControl(c))
                continue;
            if (allowLineBreaks && c is '\n' or '\r' or '\t')
                continue;
            return false;
        }

        return true;
    }

    public override string FormatErrorMessage(string name) => $"{name} contains control characters.";
}

/// <summary>Text that must not be empty or whitespace only.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class NotBlankAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) => value is not string text || !string.IsNullOrWhiteSpace(text);

    public override string FormatErrorMessage(string name) => $"{name} must not be blank.";
}

/// <summary>An absolute https URL.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class HttpsUrlAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) =>
        value is not string text
        || (Uri.TryCreate(text, UriKind.Absolute, out var uri) && uri.Scheme == Uri.UriSchemeHttps);

    public override string FormatErrorMessage(string name) => $"{name} must be an absolute https URL.";
}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class GuidStringAttribute : ValidationAttribute
{
    public override bool IsValid(object? value) => value is not string text || Guid.TryParse(text, out _);

    public override string FormatErrorMessage(string name) => $"{name} must be a GUID.";
}

/// <summary>A DTLS certificate fingerprint: colon-separated pairs of hex digits.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed partial class DtlsFingerprintAttribute : ValidationAttribute
{
    [GeneratedRegex("^[0-9A-Fa-f]{2}(:[0-9A-Fa-f]{2})*$")]
    private static partial Regex Pattern();

    public override bool IsValid(object? value) => value is not string text || Pattern().IsMatch(text);

    public override string FormatErrorMessage(string name) => $"{name} is not a fingerprint.";
}

/// <summary>The value is one of a fixed set of strings, compared without case.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
public sealed class OneOfAttribute(params string[] allowed) : ValidationAttribute
{
    public override bool IsValid(object? value) =>
        value is not string text || allowed.Contains(text, StringComparer.OrdinalIgnoreCase);

    public override string FormatErrorMessage(string name) => $"{name} must be one of: {string.Join(", ", allowed)}.";
}
