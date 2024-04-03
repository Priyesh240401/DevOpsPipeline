// UserController.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private static List<User> _users = new List<User>()
    {
        new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
        new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com" },
        // Add more users as needed
    };

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_users);
    }
}
