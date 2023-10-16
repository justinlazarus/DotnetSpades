using Microsoft.AspNetCore.Mvc;
using spades.Models;

namespace spades.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{

    private readonly ILogger<GameController> _logger;

    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetGame")]
    public Game Get()
    {
        return new Game();
    }
}
