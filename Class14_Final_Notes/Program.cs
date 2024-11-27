using ConsoleRpg.Models;

namespace ConsoleRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the GameContext with seed data
            var context = new GameContext();
            SeedData(context);

            Console.WriteLine("ConsoleRPG LINQ Examples");
            Console.WriteLine("=========================\n");

            // Example 1: List all monsters (only Goblins for now)
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 1: List all monsters (only Goblins for now)");
            Console.WriteLine("-------------------------");
            var monsters = context.Monsters.ToList();
            Console.WriteLine("All Monsters:");
            foreach (var monster in monsters)
            {
                Console.WriteLine($"Monster: {monster.Name} (Type: {monster.MonsterType}, Room: {monster.Room.Name})");
            }

            // Example 2: Goblins in a specific room
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 2: Goblins in a specific room");
            Console.WriteLine("-------------------------");
            var roomName = "Dungeon";
            var goblinsInRoom = context.Rooms
                .Where(r => r.Name == roomName)
                .SelectMany(r => r.Monsters)
                .ToList();

            Console.WriteLine($"\nMonsters in Room '{roomName}':");
            foreach (var monster in goblinsInRoom)
            {
                Console.WriteLine($"- {monster.Name} (Aggression Level: {monster.AggressionLevel})");
            }

            // Example 3: Items belonging to a specific goblin
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 3: Items belonging to a specific goblin");
            Console.WriteLine("-------------------------");
            var goblinName = "Goblin Chief";
            var itemsForGoblin = context.Monsters
                .Where(m => m.Name == goblinName)
                .SelectMany(m => m.Items)
                .ToList();

            Console.WriteLine($"\nItems for Goblin '{goblinName}':");
            foreach (var item in itemsForGoblin)
            {
                Console.WriteLine($"- {item.Name} (Type: {item.Type}, Attack: {item.Attack}, Defense: {item.Defense})");
            }

            // Example 4: Goblins with a specific item
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 4: Goblins with a specific item");
            Console.WriteLine("-------------------------");
            var itemName = "Sword";
            var goblinsWithItem = context.Items
                .Where(i => i.Name == itemName)
                .SelectMany(i => i.Monsters)
                .ToList();

            Console.WriteLine($"\nMonsters with Item '{itemName}':");
            foreach (var goblin in goblinsWithItem)
            {
                Console.WriteLine($"- {goblin.Name}");
            }

            // Example 5: Goblins with their items and room
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 5: Goblins with their items and room");
            Console.WriteLine("-------------------------");
            var goblinsWithDetails = context.Rooms
                .SelectMany(room => room.Monsters, (room, goblin) => new
                {
                    RoomName = room.Name,
                    GoblinName = goblin.Name,
                    Items = goblin.Items
                })
                .ToList();

            Console.WriteLine("Monsters with Items and Their Rooms:");
            foreach (var detail in goblinsWithDetails)
            {
                Console.WriteLine($"Room: {detail.RoomName}, Goblin: {detail.GoblinName}");
                foreach (var item in detail.Items)
                {
                    Console.WriteLine($"\tItem: {item.Name} (Type: {item.Type})");
                }
            }

            // Example 6: Find Monsters With a Specific Item in a Specific Room
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Example 6: Find Monsters With a Specific Item in a Specific Room");
            Console.WriteLine("-------------------------");
            var specificRoomName = "Dungeon";
            var specificItemName = "Sword";

            var monstersWithItemInRoom = context.Rooms
                .Where(room => room.Name == specificRoomName)
                .SelectMany(room => room.Monsters, (room, monster) => new
                {
                    RoomName = room.Name,
                    Monster = monster,
                    Items = monster.Items.Where(item => item.Name == specificItemName)
                })
                .Where(result => result.Items.Any())
                .ToList();

            Console.WriteLine($"\nMonsters in Room '{specificRoomName}' with Item '{specificItemName}':");
            foreach (var detail in monstersWithItemInRoom)
            {
                Console.WriteLine($"Room: {detail.RoomName}, Monster: {detail.Monster.Name}");

                foreach (var item in detail.Items)
                {
                    Console.WriteLine($"\tItem: {item.Name} (Type: {item.Type})");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void SeedData(GameContext context)
        {
            // Create Rooms
            var dungeon = new Room { Id = 1, Name = "Dungeon", Description = "A dark and damp room." };
            var treasureRoom = new Room { Id = 2, Name = "Treasure Room", Description = "A glittering chamber full of riches." };

            // Create Items
            var sword = new Item { Id = 1, Name = "Sword", Type = "Weapon", Attack = 10, Defense = 0, Weight = 5.5m, Value = 100 };
            var shield = new Item { Id = 2, Name = "Shield", Type = "Armor", Attack = 0, Defense = 15, Weight = 7.0m, Value = 150 };
            var potion = new Item { Id = 3, Name = "Healing Potion", Type = "Consumable", Attack = 0, Defense = 0, Weight = 1.0m, Value = 50 };

            // Create Goblins
            var goblinChief = new Goblin
            {
                Id = 1,
                Name = "Goblin Chief",
                Health = 100,
                AggressionLevel = 5,
                MonsterType = "Goblin",
                Sneakiness = 8,
                Room = dungeon,
                Items = new List<Item> { sword, shield }
            };
            var goblinMinion = new Goblin
            {
                Id = 2,
                Name = "Goblin Minion",
                Health = 50,
                AggressionLevel = 3,
                MonsterType = "Goblin",
                Sneakiness = 5,
                Room = dungeon,
                Items = new List<Item> { potion }
            };

            // Add relationships - Goblin Chief 
            dungeon.Monsters.Add(goblinChief);
            sword.Monsters.Add(goblinChief);
            shield.Monsters.Add(goblinChief);

            // Add relationships - Goblin Minion
            dungeon.Monsters.Add(goblinMinion);
            potion.Monsters.Add(goblinMinion);

            // Populate context
            context.Rooms.AddRange(new[] { dungeon, treasureRoom });
            context.Monsters.AddRange(new Goblin[] { goblinChief, goblinMinion });
            context.Items.AddRange(new[] { sword, shield, potion });
        }
    }
}
