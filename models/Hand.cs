namespace spades.Models;

public class Hand {
    public int Id { get; set; }
    public int GameId { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public Game Game { get; set; } = null!;

    public Hand() => this.StartStamp = DateTime.UtcNow;
}
