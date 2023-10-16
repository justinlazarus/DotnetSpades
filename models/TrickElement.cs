using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class TrickElement {
    public int Id { get; set; }
    public DateTime PlayStamp { get; set; }

    // parents
    public Trick Trick { get; set; } = null!;
    public Card Card { get; set; } = null!;
}