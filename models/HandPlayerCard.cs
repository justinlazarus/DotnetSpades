namespace spades.Models;

public class HandPlayerCard {
    public int Id { get; set; }
    public int HandPlayerId { get; set; }
    public int CardId { get; set; }

    public HandPlayer HandPlayer { get; set; } = null!;
    public Card Card { get; set; } = null!;
}
