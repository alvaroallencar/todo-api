using ToDoApi.Contracts;
using ToDoApi.Entities;

namespace ToDoApi.UseCases;

public class GetToDoById(IToDoRepository toDoRepository) : IGetToDoById
{
    public async Task<ToDo?> Execute(Guid toDoId)
    {
        return await toDoRepository.GetToDo(toDoId);
    }
}