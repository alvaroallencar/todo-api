using Microsoft.EntityFrameworkCore;
using ToDoApi.Entities;

namespace ToDoApi.Database;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<ToDo> ToDos { get; set; }
}