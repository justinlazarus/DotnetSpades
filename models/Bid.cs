using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Bid {
    public int Id { get; set; }
    public int TrickCount { get; set; }

    // parents
    public Hand Hand { get; set; } = null!;
    public Player Player { get; set; } = null!;
}