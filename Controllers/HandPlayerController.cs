using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class HandPlayerController : ControllerBase {
    private readonly SpadesContext _context;

    public HandPlayerController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<HandPlayer>>> GetHandPlayers() {
        return Ok(await _context.HandPlayers.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<HandPlayer>>> AddHandPlayer(int handId, int playerId) {
        var hand = await _context.Hands.FindAsync(handId);
        if (hand is null) return BadRequest("Hand not found");

        var player = await _context.Players.FindAsync(playerId);
        if (player is null) return BadRequest("Player not found");

	_context.HandPlayers.Add(new HandPlayer { HandId = hand.Id, PlayerId = player.Id });
        await _context.SaveChangesAsync();

        return Ok(await _context.HandPlayers.Where(h => h.HandId == handId).ToListAsync());
    }

    [HttpDelete]
    public async Task<ActionResult<List<HandPlayer>>> Delete(int id) {
        var hp = await _context.HandPlayers.FindAsync(id);
        if (hp is null) return BadRequest("HandPlayer not found.");

        _context.HandPlayers.Remove(hp);
        await _context.SaveChangesAsync();

        return Ok(await _context.HandPlayers.ToListAsync());
    }

}
