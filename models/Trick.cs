namespace spades.Models;

public class Trick {
    public int Id { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime EndStamp { get; set; }

    // parents
    public Hand Hand { get; set; }

    // children
    public ICollection<TrickElement> TrickElements { get; } = new List<TrickElement>();
}