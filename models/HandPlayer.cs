namespace spades.Models;

public class HandPlayer {
    public int Id { get; set; }
    public int HandId { get; set; }
    public int PlayerId { get; set; }

    public Hand Hand { get; set; } = null!;
    public Player Player { get; set; } = null!;
}
