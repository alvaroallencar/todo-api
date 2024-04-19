using ToDoApi.Controllers.Dtos;
using ToDoApi.Entities;

namespace ToDoApi.Contracts;

public interface ICreateToDo
{
    Task<ToDo?> Execute(CreateToDoDto toDoDto);
}