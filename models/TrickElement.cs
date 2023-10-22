namespace spades.Models;

public class TrickElement {
    public int Id { get; set; }
    public int HandPlayerCardId { get; set; }
    public int TrickId { get; set; }
    public DateTime PlayStamp { get; set; }

    public Trick Trick { get; set; } = null!;
    public HandPlayerCard HandPlayerCard { get; set; } = null!;

    public TrickElement() => this.PlayStamp = DateTime.UtcNow;
}
