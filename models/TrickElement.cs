namespace spades.Models;

public class TrickElement {
    public int Id { get; set; }
    public int TrickId {get; set; }
    public int CardId { get; set; }
    public DateTime PlayStamp { get; set; }

    public Trick Trick { get; set; } = null!;
    public Card Card { get; set; } = null!;
}
