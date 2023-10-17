namespace spades.Models;

public class Card{
    public int Id { get; set; }
    public int Suit { get; set; }
    public int Value { get; set; }

    public ICollection<TrickElement> TrickElements { get; set; }
}