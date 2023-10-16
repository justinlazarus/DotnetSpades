using spades.Models;
using Microsoft.EntityFrameworkCore;

namespace spades.Data;

public class SpadesContext : DbContext {
    public DbSet<Bid> Bids { get; set; } = null!;
    public DbSet<Card> Cards { get; set; } = null!;
    public DbSet<Game> Games { get; set; } = null!;
    public DbSet<Hand> Hands { get; set; } = null!;
    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<Trick> Tricks { get; set; } = null!;
    public DbSet<TrickElement> TrickElemenents { get; set; } = null!;

    protected readonly IConfiguration Configuration;

    public SpadesContext(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite(Configuration.GetConnectionString("SpadesDb"));
    }
}