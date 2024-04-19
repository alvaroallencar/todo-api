using Microsoft.AspNetCore.Mvc;
using ToDoApi.Contracts;
using ToDoApi.Controllers.Dtos;

namespace ToDoApi.Controllers;

public class ToDoController : ToDoBaseController
{
    [HttpGet]
    [Route("{todoId:guid:required}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetToDo([FromRoute] Guid todoId, [FromServices] IGetToDoById getToDoById)
    {
        var foundToDo = await getToDoById.Execute(todoId);

        return Ok(foundToDo);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateToDo([FromBody] CreateToDoDto createToDoDto,
        [FromServices] ICreateToDo createToDo)
    {
        var newToDo = await createToDo.Execute(createToDoDto);

        return CreatedAtAction(nameof(GetToDo), new { todoId = newToDo?.Id }, newToDo);
    }
}