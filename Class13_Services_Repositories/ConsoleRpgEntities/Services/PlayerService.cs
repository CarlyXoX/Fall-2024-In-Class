using ConsoleRpgEntities.Models.Attributes;
using ConsoleRpgEntities.Models.Characters;
using ConsoleRpgEntities.Models.Equipments;
using ConsoleRpgEntities.Repositories;

namespace ConsoleRpgEntities.Services
{
    public class PlayerService
    {
        private readonly ItemRepository _itemRepository;

        public PlayerService(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void Attack(Player player, ITargetable target)
        {
            // Player-specific attack logic
            Console.WriteLine($"{player.Name} attacks {target.Name} with a {player.Equipment.Weapon.Name} dealing {player.Equipment.Weapon.Attack} damage!");
            target.Health -= player.Equipment.Weapon.Attack;
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");

        }
    }
}
