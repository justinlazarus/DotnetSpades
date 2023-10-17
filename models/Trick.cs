using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Trick {
    public int Id { get; set; }
    public int HandId { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public Hand Hand { get; set; }

    public ICollection<TrickElement> TrickElements { get; set; }
}