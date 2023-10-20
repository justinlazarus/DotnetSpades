using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase {
    private readonly SpadesContext _context;

    public GameController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Game>>> GetGames() {
        return Ok(await _context.Games.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGame(int id) {
        var game = await _context.Games.FindAsync(id);
        if (game is null) return BadRequest("Game not found.");
        return Ok(game);
    }

    [HttpPost]
    public async Task<ActionResult<List<Game>>> AddGame(Game game) {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();

        return Ok(await _context.Games.ToListAsync());
    }

    [HttpPut]
    public async Task<ActionResult<List<Game>>> UpdateGame(Game request) {
        var game = await _context.Games.FindAsync(request.Id);
        if (game is null) return BadRequest("Game not found.");
        
        game.StartStamp = request.StartStamp;
        game.EndStamp = request.EndStamp;

        await _context.SaveChangesAsync();

        return Ok(await _context.Games.ToListAsync());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Game>>> Delete(int id) {
        var game = await _context.Games.FindAsync(id);
        if (game is null) return BadRequest("Game not found.");

        _context.Games.Remove(game);
        await _context.SaveChangesAsync();

        return Ok(await _context.Games.ToListAsync());
    }
}
