using ToDoApi.Controllers.Dtos;
using ToDoApi.Entities;

namespace ToDoApi.Contracts;

public interface IToDoRepository
{
    Task<ToDo?> GetToDo(Guid id);
    Task<ToDo> CreateToDo(CreateToDoDto todo);
}