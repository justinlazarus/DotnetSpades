using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controllers;


[ApiController]
[Route("[controller]")]
public class HandController : ControllerBase {
    private readonly SpadesContext _context;

    public HandController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<Hand>>> GetHands() {
        return Ok(await _context.Hands.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Hand>> GetHand(int id) {
        var hand = await _context.Hands.FindAsync(id);
        if (hand is null) return BadRequest("Hand not found.");
        return Ok(hand);
    }

    [HttpPost]
    public async Task<ActionResult<List<Hand>>> AddHand(int gameId) {
        var game = await _context.Games.FindAsync(gameId);
        if (game is null) return BadRequest("Game not found");
        _context.Hands.Add(new Hand{Game = game});
        await _context.SaveChangesAsync();
        return Ok(await _context.Hands.ToListAsync());
    }

    [HttpPut]
    public async Task<ActionResult<List<Hand>>> UpdateHand(Hand request) {
        var hand = await _context.Hands.FindAsync(request.Id);
        if (hand is null) return BadRequest("Hand not found.");
        hand.StartStamp = request.StartStamp;
        hand.EndStamp = request.EndStamp;
        await _context.SaveChangesAsync();
        return Ok(await _context.Hands.FindAsync(request.Id));
    }

    [HttpDelete]
    public async Task<ActionResult<List<Hand>>> Delete(int id) {
        var hand = await _context.Hands.FindAsync(id);
        if (hand is null) return BadRequest("Hand not found.");
        _context.Hands.Remove(hand);
        await _context.SaveChangesAsync();
        return Ok(await _context.Hands.ToListAsync());
    }

    [HttpPost("/deal")]
    public async Task<ActionResult<List<HandPlayerCard>>> Deal(int handId) {
        var hand = await _context.Hands.FindAsync(handId);
        if (hand is null) return BadRequest("Hand not found.");

        var cards = await _context.Cards.ToListAsync();
        if (cards is null) return BadRequest("Cards not found.");

	// Although this is a shitty way to shuffle, there are only 52 cards so
	// good enough
	var shuffledCards = cards.OrderBy(c => Guid.NewGuid()).ToList();
        var handPlayers = await _context.HandPlayers
	    .Where(h => h.HandId == handId).ToListAsync();

        foreach (HandPlayer hp in handPlayers) {
            foreach (Card card in shuffledCards.GetRange(0,13)) {
                _context.HandPlayerCards.Add(new HandPlayerCard {
		    HandPlayer = hp,
                    Card = card
                });
            }
            shuffledCards.RemoveRange(0,13);
        }

        await _context.SaveChangesAsync();
        return Ok(await _context.HandPlayerCards.ToListAsync());
    }

    [HttpPut("/completeHand")]
    public async Task<ActionResult<Hand>> CompleteHand(int handId) {
        var hand = await _context.Hands.FindAsync(handId);
        if (hand is null) return BadRequest("Hand not found.");
        hand.EndStamp = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return Ok(await _context.Hands.FindAsync(handId));
    }
    
    [HttpGet("/getActiveTrick")]
    public async Task<ActionResult<List<Trick>>> GetActiveTrick(int handId) {
        var hand = await _context.Hands.FindAsync(handId);
        if (hand is null) return BadRequest("Hand not found.");
        return Ok(
	    await _context.Tricks
	    .Where(t => t.HandId == handId && t.EndStamp == null)
	    .ToListAsync()
	);
    }
}
