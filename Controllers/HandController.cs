
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
    public async Task<ActionResult<List<Hand>>> AddHand(Hand hand) {
        _context.Hands.Add(hand);
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

        return Ok(await _context.Hands.ToListAsync());
    }

    [HttpDelete]
    public async Task<ActionResult<List<Hand>>> Delete(int id) {
        var hand = await _context.Hands.FindAsync(id);
        if (hand is null) return BadRequest("Hand not found.");

        _context.Hands.Remove(hand);
        await _context.SaveChangesAsync();

        return Ok(await _context.Hands.ToListAsync());
    }
}