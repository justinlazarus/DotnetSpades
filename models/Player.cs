using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Player {
    public int Id  { get; set; }
    public string Name { get; set; }
    public string? Nickname { get; set; }
    
    public List<TrickElement> TrickElements { get; } = new();
    public List<Bid> Bids { get; } = new();
}