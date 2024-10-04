using Class07_Prep.Interfaces;
using Class07_Prep.Models.Rooms;

namespace Class07_Prep.Models.Characters
{
    public class Ghost : CharacterBase, IFlyable, ILootable
    {
        public string Treasure { get; set; }

        public Ghost() : base() {  }

        public Ghost(IRoom room) : base(room)
        {
        }

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
