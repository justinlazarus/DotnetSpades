using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;
using SQLitePCL;

namespace spades.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly SpadesContext _context;

    public GameController(SpadesContext context) {
        _context = context;
    }

    [HttpGet(Name = "GetGame")]
    public async Task<ActionResult<List<Game>>> Get() {
        var games = new List<Game>();
        return Ok(await _context.Games.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> Get(int id) {
        var game = await _context.Games.FindAsync(id);
        if (game == null) return BadRequest("Game not found.");
        return Ok(game);
    }

}