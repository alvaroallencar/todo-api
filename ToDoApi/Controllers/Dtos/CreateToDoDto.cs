using ToDoApi.Entities;

namespace ToDoApi.Controllers.Dtos;

public record CreateToDoDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
}