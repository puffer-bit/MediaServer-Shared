namespace Shared.Models.Requests;

public abstract record Request : BaseMessage, IUserMessage
{
    public Guid RequestId { get; init; } = Guid.NewGuid();
            
    public int UserId { get; set; }
}