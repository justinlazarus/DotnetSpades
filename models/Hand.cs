using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Hand {
    public int Id { get; set; }
    public int GameId { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime? EndStamp { get; set; }

    public Game Game { get; set; }

    public ICollection<Bid> Bids { get; set; }
    public ICollection<Trick> Tricks { get; set; }
}