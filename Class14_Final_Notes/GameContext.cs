
using ConsoleRpg.Models;

namespace ConsoleRpg;

public class GameContext
{
    // In-memory collections for data storage
    public List<Room> Rooms { get; set; } = new List<Room>();
    public List<Monster> Monsters { get; set; } = new List<Monster>();
    public List<Item> Items { get; set; } = new List<Item>();


    // The following configurations are for EF Core when using a database.
    // Since we're using in-memory storage with List<T> in this example, these are not needed.
    // Uncomment this method if transitioning back to Entity Framework Core with a database connection.
    // Remember that if your model is setup correctly, EF Core will infer the relationships without these configurations.
    /*
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // One-to-many: Room -> Monsters
    modelBuilder.Entity<Monster>()
        .HasOne(m => m.Room)
        .WithMany(r => r.Monsters)
        .HasForeignKey(m => m.RoomId)
        .OnDelete(DeleteBehavior.Cascade);

    // Many-to-many: Monsters <-> Items
    modelBuilder.Entity<Monster>()
        .HasMany(m => m.Items)
        .WithMany(i => i.Monsters)
        .UsingEntity(j => j.ToTable("MonsterItems"));
}
*/


}