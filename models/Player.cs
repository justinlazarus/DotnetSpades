namespace spades.Models;

public class Player {
    public int Id  { get; set; }
    public string Name { get; set; }
    public string? Nickname { get; set; }
    
    // children
    public ICollection<TrickElement> TrickElements { get; } = new List<TrickElement>();
    public ICollection<Bid> Bids { get; } = new List<Bid>();
}