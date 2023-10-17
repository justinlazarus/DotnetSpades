using System.ComponentModel.DataAnnotations;

namespace spades.Models;

public class Hand {
    public int Id { get; set; }
    public DateTime StartStamp { get; set; }
    public DateTime EndStamp { get; set; }

    public int GameId { get; set; } 
    public virtual Game Game { get; set; } = null!;

    public ICollection<Bid> Bids { get; } = new List<Bid>();
    public ICollection<Trick> Tricks { get; } = new List<Trick>();
}