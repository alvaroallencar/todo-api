using ToDoApi.Contracts;

namespace ToDoApi.Extensions;

public static class Extensions
{
    public static IServiceCollection AddToDoServices(this IServiceCollection services)
        => services.AddScoped<IToDoRepository, IToDoRepository>();
}