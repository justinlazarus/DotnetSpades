using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Hand {
    public int Id { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public int GameId { get; set; }
    public Game Game { get; set; }

    public List<Bid> Bids { get; } = new();
    public List<Trick> Tricks { get; } = new();
}