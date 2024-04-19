using ToDoApi.Contracts;
using ToDoApi.Controllers.Dtos;
using ToDoApi.Entities;

namespace ToDoApi.Database.Repositories;

public class ToDoRepository(DataContext dataContext) : IToDoRepository
{
    public async Task<ToDo?> GetToDo(Guid id)
    {
        var foundToDo = await dataContext.ToDos.FindAsync(id);

        if (foundToDo is null)
            throw new Exception("ToDo not found");

        return foundToDo;
    }

    public async Task<ToDo> CreateToDo(CreateToDoDto todo)
    {
        var newToDo = new ToDo()
        {
            Title = todo.Title,
            Content = todo.Content,
            DueDate = todo.DueDate,
            Priority = todo.Priority,
            Status = todo.Status
        };

        dataContext.ToDos.Add(newToDo);
        await dataContext.SaveChangesAsync();

        return newToDo;
    }
}