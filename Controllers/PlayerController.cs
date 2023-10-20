using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase {
    private readonly SpadesContext _context;

    public PlayerController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Player>>> GetPlayers() {
        return Ok(await _context.Players.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<Player>>> AddPlayer(string name) {
	_context.Players.Add(new Player { Name = name });
        await _context.SaveChangesAsync();

        return Ok(await _context.Players.ToListAsync());
    }
}
