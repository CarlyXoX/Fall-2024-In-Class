using Class06_DIP.Interfaces;

namespace Class06_DIP.Models
{
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        public virtual void Move() // you can override
        {
            Console.WriteLine($"{Name} moves");
        }

        public abstract void SpecialAction(); // must have this method
    }
}
