using Class07_Prep.Models.Rooms;

namespace Class07_Prep.Models.Characters
{
    public class Goblin : CharacterBase, ILootable
    {
        public string Treasure { get; set; }

        public Goblin() : base() { }

        public Goblin(IRoom room) : base(room)
        {
        }

        public override void Move(string? direction = null) // override a virtual method
        {
            Console.WriteLine($"{Name} moves aggressively forward");
        }

        public override void SpecialAction()
        {
            throw new NotImplementedException();
        }
    }
}
