using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Bid {
    public int Id { get; set; }
    public int HandId { get; set; }
    public int PlayerId { get; set; }
    public int TrickCount { get; set; }

    public Hand Hand { get; set; }
    public Player Player { get; set; } 

    public override string ToString() {
        return $"Bid {Id} Player {Player.Name} {TrickCount} tricks";
    }
}