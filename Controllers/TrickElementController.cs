using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spades.Models;

namespace spades.Controller;

[ApiController]
[Route("[controller]")]
public class TrickElementController : ControllerBase {
    private readonly SpadesContext _context;

    public TrickElementController(SpadesContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<List<TrickElement>>> GetTrickElement() {
        return Ok(await _context.TrickElements.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<TrickElement>>> AddTrickElement(
      TrickElement trickElement
    ) {
	_context.TrickElements.Add(trickElement);
        await _context.SaveChangesAsync();

        return Ok(await _context.TrickElements.ToListAsync());
    }

}
