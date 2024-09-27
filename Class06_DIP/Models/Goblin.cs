namespace Class06_DIP.Models
{
    public class Goblin : CharacterBase, ILootable
    {
        public string Treasure { get; set; }

        public override void Move() // override a virtual method
        {
            Console.WriteLine($"{Name} moves aggressively forward");
        }

        public override void SpecialAction()
        {
            throw new NotImplementedException();
        }
    }
}
