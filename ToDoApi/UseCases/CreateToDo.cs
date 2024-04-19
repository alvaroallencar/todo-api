using ToDoApi.Contracts;
using ToDoApi.Controllers.Dtos;
using ToDoApi.Entities;

namespace ToDoApi.UseCases;

public class CreateToDo(IToDoRepository toDoRepository) : ICreateToDo
{
    public async Task<ToDo?> Execute(CreateToDoDto toDoDto)
    {
        return await toDoRepository.CreateToDo(toDoDto);
    }
}