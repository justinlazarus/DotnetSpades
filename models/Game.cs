namespace spades.Models;

public class Game {
    public int Id { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public ICollection<Hand> Hands { get; set; }
}