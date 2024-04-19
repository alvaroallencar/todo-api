using ToDoApi.Contracts;
using ToDoApi.Database.Repositories;
using ToDoApi.UseCases;

namespace ToDoApi.Extensions;

public static class Extensions
{
    public static IServiceCollection AddToDoServices(this IServiceCollection services)
        => services
            .AddScoped<IToDoRepository, ToDoRepository>()
            .AddScoped<ICreateToDo, CreateToDo>()
            .AddScoped<IGetToDoById, GetToDoById>();
}