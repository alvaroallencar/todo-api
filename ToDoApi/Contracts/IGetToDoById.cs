using ToDoApi.Entities;

namespace ToDoApi.Contracts;

public interface IGetToDoById
{
    Task<ToDo?> Execute(Guid toDoId);
}