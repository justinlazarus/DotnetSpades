namespace spades.Models;

public class HandPlayerCard {
    public int Id { get; set; }
    public int HandId { get; set; }
    public int PlayerId { get; set; }
    public int CardId { get; set; }

    public Game Hand { get; set; } = null!;
    public Game Player { get; set; } = null!;
    public Game Card { get; set; } = null!;
}
