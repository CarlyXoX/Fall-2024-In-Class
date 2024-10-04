using Class07_Prep.Models.Rooms;

namespace Class07_Prep.Models.Characters
{
    public class Player : CharacterBase
    {
        public int Gold { get; set; }

        // default constructor for deserialization
        public Player() : base() { }


        // non-default: used in our program
        public Player(IRoom room) : base(room)
        {            
        }

        public override void SpecialAction()
        {
            // teleport player
            // CurrentRoom = room; (for example)
            throw new NotImplementedException();

        }

        //public void Look(IRoom roomToLookAt)
        //{
        //    Console.WriteLine($"The player looks and sees {roomToLookAt.Name}");
        //}

        //public override string ToString()
        //{
        //    return $"{Id}: {Name}";
        //}
    }
}
