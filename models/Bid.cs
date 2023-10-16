namespace spades.Models;

public class Bid {
    public int Id { get; set; }
    public int TrickCount { get; set; }

    // parents
    public Hand Hand { get; set; }
    public Player Player { get; set; }
}