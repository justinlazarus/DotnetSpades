using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class CardController : ControllerBase {
    private readonly SpadesContext _context;

    public CardController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Card>>> GetCards() {
        return Ok(await _context.Cards.ToListAsync());
    }
}
