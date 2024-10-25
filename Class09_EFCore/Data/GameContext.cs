using Class09_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Class09_EFCore.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=bitsql.wctc.edu;Database=EFCore_mmcarthey;User Id=mmcarthey;Password=redacted;");
        }

        public void Seed()
        {
            if (!Rooms.Any())
            {
                var room1 = new Room()
                {
                    Name = "Entrance",
                    Description = "A big entrance hall"
                };

                var room2 = new Room()
                {
                    Name = "Dungeon",
                    Description = "A scary dungeon"
                };
                Rooms.Add(room1);
                Rooms.Add(room2);

                var character1 = new Character()
                {
                    Name = "Bob",
                    Level = 1,
                    Room = room1
                };
                var character2 = new Character()
                {
                    Name = "June",
                    Level = 1,
                    Room = room2
                };

                Characters.AddRange(character1, character2);

                SaveChanges();
            }
        }
    }
}
