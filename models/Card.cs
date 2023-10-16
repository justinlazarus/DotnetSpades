namespace spades.Models;

public class Card{
    public int Id { get; set; }
    public int Suit { get; set; }
    public int Value { get; set; }

    // children
    public ICollection<TrickElement> TrickElements { get; } = new List<TrickElement>();
}