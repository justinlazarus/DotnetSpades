using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Bid {
    public int Id { get; set; }
    public int TrickCount { get; set; }

    public int HandId { get; set; }
    public virtual Hand Hand { get; set; } = null!;
    public int PlayerId { get; set; }
    public virtual Player Player { get; set; } = null!;

    public override string ToString() {
        return $"Bid {Id} Player {Player.Name} {TrickCount} tricks";
    }
}