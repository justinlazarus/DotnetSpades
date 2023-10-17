using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class TrickElement {
    public int Id { get; set; }
    public DateTime PlayStamp { get; set; }

    public int TrickId {get; set; }
    public virtual Trick Trick { get; set; } = null!;
    public int CardId { get; set; }
    public virtual Card Card { get; set; } = null!;
}