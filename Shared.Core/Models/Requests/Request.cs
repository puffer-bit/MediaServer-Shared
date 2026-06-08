namespace Shared.Models.Requests;

public abstract record Request()
{
    public string RequestId { get; init; } = Guid.NewGuid().ToString();
}