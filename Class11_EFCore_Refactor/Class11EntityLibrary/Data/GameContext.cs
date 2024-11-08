using Class11EntityLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace Class11EntityLibrary.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Room> Rooms { get; set; }

        // design time
        public GameContext()
        {

        }

        // run time - for dependency injection
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FluentAPI
            // Table Per Hierarchy (TPH)
            // configure the character entity
            modelBuilder.Entity<Character>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Player>("Player")
                .HasValue<Goblin>("Goblin");

            base.OnModelCreating(modelBuilder);
        }
    }
}
