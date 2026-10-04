using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Shared.Validation;

/// <summary>
/// Checks a message against the validation attributes of its own properties and of every nested
/// Shared object and collection item. The standard <see cref="Validator"/> stops at the top level.
/// </summary>
public static class MessageValidator
{
    private const int MaxDepth = 8;
    private static readonly Assembly SharedAssembly = typeof(MessageValidator).Assembly;

    public static bool TryValidate(object message, out IReadOnlyList<string> errors)
    {
        var found = new List<string>();
        Validate(message, message.GetType().Name, found, 0);
        errors = found;
        return found.Count == 0;
    }

    private static void Validate(object instance, string path, List<string> errors, int depth)
    {
        if (depth > MaxDepth)
        {
            errors.Add($"{path}: nested too deeply.");
            return;
        }

        var results = new List<ValidationResult>();
        Validator.TryValidateObject(instance, new ValidationContext(instance), results, validateAllProperties: true);
        foreach (var result in results)
            errors.Add($"{path}: {result.ErrorMessage}");

        foreach (var property in instance.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (property.GetIndexParameters().Length > 0 || property.DeclaringType == typeof(object))
                continue;

            var value = property.GetValue(instance);
            if (value == null || IsLeaf(value.GetType()))
                continue;

            var propertyPath = $"{path}.{property.Name}";
            if (value is IEnumerable items)
            {
                var index = 0;
                foreach (var item in items)
                {
                    if (item != null && IsSharedObject(item.GetType()))
                        Validate(item, $"{propertyPath}[{index}]", errors, depth + 1);
                    index++;
                }
            }
            else if (IsSharedObject(value.GetType()))
            {
                Validate(value, propertyPath, errors, depth + 1);
            }
        }
    }

    private static bool IsLeaf(Type type) =>
        type.IsPrimitive || type.IsEnum || type == typeof(string) || type == typeof(decimal)
        || type == typeof(DateTime) || type == typeof(DateTimeOffset) || type == typeof(TimeSpan) || type == typeof(Guid);

    private static bool IsSharedObject(Type type) => type.Assembly == SharedAssembly && !IsLeaf(type);
}
