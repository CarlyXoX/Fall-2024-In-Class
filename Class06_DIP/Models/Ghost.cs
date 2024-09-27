using Class06_DIP.Interfaces;

namespace Class06_DIP.Models
{
    public class Ghost : CharacterBase, IFlyable, ILootable
    {
        public string Treasure { get; set; }

        public void Fly()
        {
            Console.WriteLine("The ghost flies silently");
        }

        public override void SpecialAction()
        {
            throw new NotImplementedException();
        }
    }
}
