using ConsoleRpgEntities.Models.Abilities.PlayerAbilities;

namespace ConsoleRpgEntities.Models.Characters;

public interface IPlayer
{
    int Id { get; set; }
    string Name { get; set; }
    int Experience { get; set; }
    int Health { get; set; }


    ICollection<Ability> Abilities { get; set; }
}
