using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Player {
    public int Id  { get; set; }
    public string Name { get; set; }
    public string? Nickname { get; set; }
    
    public ICollection<TrickElement> TrickElements { get; set; }
    public ICollection<Bid> Bids { get; set; }
}