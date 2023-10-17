using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Trick {
    public int Id { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public int HandId { get; set; }
    public virtual Hand Hand { get; set; } = null!;

    public ICollection<TrickElement> TrickElements { get; } = new List<TrickElement>();
}