using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controllers;

public class ToDoController : ToDoBaseController
{
    [HttpGet]
    [Route("{todoId:guid:required}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetToDo([FromRoute] Guid todoId)
    {
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult CreateToDo()
    {
        return Created(string.Empty, "");
    }
}