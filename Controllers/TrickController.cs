using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class TrickController : ControllerBase {
    private readonly SpadesContext _context;

    public TrickController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Trick>>> GetTricks() {
        return Ok(await _context.Tricks.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<Trick>>> AddTrick(int handId) {
	var hand = await _context.Hands.FindAsync(handId);
	if (hand is null) return BadRequest("Hand not found");

	_context.Tricks.Add(new Trick{Hand = hand});
        await _context.SaveChangesAsync();

        return Ok(await _context.Tricks.ToListAsync());
    }

    [HttpPost("/playCard")]
    public async Task<ActionResult<List<TrickElement>>> PlayCard(int trickId, int hpcId) {
	var trick = await _context.Tricks.FindAsync(trickId);
	if (trick is null) return BadRequest("Trick not found");

	var hpc = await _context.HandPlayerCards.FindAsync(hpcId);
	if (hpc is null) return BadRequest("Hand player card not found");

	_context.TrickElements.Add(new TrickElement{
	    Trick = trick,
	    HandPlayerCard = hpc
        });

	await _context.SaveChangesAsync();
	return Ok(await _context.TrickElements.ToListAsync());
    }
}
