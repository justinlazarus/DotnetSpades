using spades.Models;
using Microsoft.EntityFrameworkCore;

namespace spades.Data;

public class SpadesContext : DbContext {
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Hand> Hands { get; set; }
    public DbSet<HandPlayer> HandPlayers { get; set; }
    public DbSet<HandPlayerCard> HandPlayerCards { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Trick> Tricks { get; set; }
    public DbSet<TrickElement> TrickElemenents { get; set; }

    protected readonly IConfiguration Configuration;

    public SpadesContext(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options.UseSqlite(Configuration.GetConnectionString("SpadesDb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.Entity<Card>().HasData(

            // spades
            new Card() { Id = 1, Suit = 1, Value = 2 },
            new Card() { Id = 2, Suit = 1, Value = 3 },
            new Card() { Id = 3, Suit = 1, Value = 4 },
            new Card() { Id = 4, Suit = 1, Value = 5 },
            new Card() { Id = 5, Suit = 1, Value = 6 },
            new Card() { Id = 6, Suit = 1, Value = 7 },
            new Card() { Id = 7, Suit = 1, Value = 8 },
            new Card() { Id = 8, Suit = 1, Value = 9 },
            new Card() { Id = 9, Suit = 1, Value = 10 },
            new Card() { Id = 10, Suit = 1, Value = 11 },
            new Card() { Id = 11, Suit = 1, Value = 12 },
            new Card() { Id = 12, Suit = 1, Value = 13 },
            new Card() { Id = 13, Suit = 1, Value = 14 },

            // hearts
            new Card() { Id = 14, Suit = 2, Value = 2 },
            new Card() { Id = 15, Suit = 2, Value = 3 },
            new Card() { Id = 16, Suit = 2, Value = 4 },
            new Card() { Id = 17, Suit = 2, Value = 5 },
            new Card() { Id = 18, Suit = 2, Value = 6 },
            new Card() { Id = 19, Suit = 2, Value = 7 },
            new Card() { Id = 20, Suit = 2, Value = 8 },
            new Card() { Id = 21, Suit = 2, Value = 9 },
            new Card() { Id = 22, Suit = 2, Value = 10 },
            new Card() { Id = 23, Suit = 2, Value = 11 },
            new Card() { Id = 24, Suit = 2, Value = 12 },
            new Card() { Id = 25, Suit = 2, Value = 13 },
            new Card() { Id = 26, Suit = 2, Value = 14 },

            // diamonds
            new Card() { Id = 27, Suit = 3, Value = 2 },
            new Card() { Id = 28, Suit = 3, Value = 3 },
            new Card() { Id = 29, Suit = 3, Value = 4 },
            new Card() { Id = 30, Suit = 3, Value = 5 },
            new Card() { Id = 31, Suit = 3, Value = 6 },
            new Card() { Id = 32, Suit = 3, Value = 7 },
            new Card() { Id = 33, Suit = 3, Value = 8 },
            new Card() { Id = 34, Suit = 3, Value = 9 },
            new Card() { Id = 35, Suit = 3, Value = 10 },
            new Card() { Id = 36, Suit = 3, Value = 11 },
            new Card() { Id = 37, Suit = 3, Value = 12 },
            new Card() { Id = 38, Suit = 3, Value = 13 },
            new Card() { Id = 39, Suit = 3, Value = 14 },

            // clubs
            new Card() { Id = 40, Suit = 4, Value = 2 },
            new Card() { Id = 41, Suit = 4, Value = 3 },
            new Card() { Id = 42, Suit = 4, Value = 4 },
            new Card() { Id = 43, Suit = 4, Value = 5 },
            new Card() { Id = 44, Suit = 4, Value = 6 },
            new Card() { Id = 45, Suit = 4, Value = 7 },
            new Card() { Id = 46, Suit = 4, Value = 8 },
            new Card() { Id = 47, Suit = 4, Value = 9 },
            new Card() { Id = 48, Suit = 4, Value = 10 },
            new Card() { Id = 49, Suit = 4, Value = 11 },
            new Card() { Id = 50, Suit = 4, Value = 12 },
            new Card() { Id = 51, Suit = 4, Value = 13 },
            new Card() { Id = 52, Suit = 4, Value = 14 }
        );
    }
}
