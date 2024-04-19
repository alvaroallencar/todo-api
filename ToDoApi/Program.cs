using System.Text.Json.Serialization;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ToDoApi.Database;
using ToDoApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Loads Environment Variables
Env.Load("../.env");

// Adds support to convert enums
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

// Adds swagger tags
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ToDo API",
        Version = "v1",
        Description = "A simple api to manage tasks (ToDos)",
    });
});

// Adds postgres database connection
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(Env.GetString("DB_CONNECTION_STRING")));

// Adds To Do services
builder.Services.AddToDoServices();

var app = builder.Build();

// Adds swagger in development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Runs migrations when API starts
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<DataContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();