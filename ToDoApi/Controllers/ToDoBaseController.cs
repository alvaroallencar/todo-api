using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controllers;

[Route("/api/v1/[controller]")]
[ApiController]
public class ToDoBaseController : ControllerBase
{
}