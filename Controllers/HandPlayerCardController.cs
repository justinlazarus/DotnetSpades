using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class HandPlayerCardController : ControllerBase {
    private readonly SpadesContext _context;

    public HandPlayerCardController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<HandPlayerCard>>> GetHandPlayerCards() {
        return Ok(await _context.HandPlayerCards.ToListAsync());
    }

    [HttpDelete]
    public async Task<ActionResult<List<HandPlayerCard>>> Delete(int id) {
        var hpc = await _context.HandPlayerCards.FindAsync(id);
        if (hpc is null) return BadRequest("Hand Player Card not found.");

        _context.HandPlayerCards.Remove(hpc);
        await _context.SaveChangesAsync();

        return Ok(await _context.HandPlayerCards.ToListAsync());
    }
}
