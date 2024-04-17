namespace ToDoApi.Entities;

public class ToDo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; } = Priority.Uncategorized;
    public Status Status { get; set; } = Status.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
}

public enum Status
{
    Pending,
    InProgress,
    Complete
}

public enum Priority
{
    Uncategorized,
    Low,
    Medium,
    High
}