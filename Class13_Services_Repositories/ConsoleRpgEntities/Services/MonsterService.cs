using ConsoleRpgEntities.Models.Attributes;
using ConsoleRpgEntities.Models.Characters.Monsters;

namespace ConsoleRpgEntities.Services
{
    public class MonsterService
    {
        public void Attack(IMonster monster, ITargetable target)
        {
            // Goblin-specific attack logic
            Console.WriteLine($"{monster.Name} sneaks up and attacks {target.Name}!");
        }
    }
}
