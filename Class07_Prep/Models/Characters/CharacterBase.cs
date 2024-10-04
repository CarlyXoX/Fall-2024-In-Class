using Class07_Prep.Interfaces;
using Class07_Prep.Models.Rooms;

namespace Class07_Prep.Models.Characters
{
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        protected IRoom CurrentRoom { get; set; }

        // default constructor for deserialization
        public CharacterBase() { }

        public CharacterBase(IRoom room)
        {
            CurrentRoom = room;
        }

        public void EnterRoom(IRoom room)
        {
            // verify no monsters in room
            // verify room not trapped
            CurrentRoom = room;
            Console.WriteLine($"{Name} moves into {room.Name}");
        }

        public virtual void Move(string? direction = null) // you can override
        {
            IRoom nextRoom;
            switch (direction)
            {
                case "north":
                    nextRoom = CurrentRoom.North;
                    break;
                case "south":
                    nextRoom = CurrentRoom.South;
                    break;
                case "east":
                    nextRoom = CurrentRoom.East;
                    break;
                case "west":
                    nextRoom = CurrentRoom.West;
                    break;
                default:
                    nextRoom = null;
                    break;
            }

            if (nextRoom != null)
            {
                EnterRoom(nextRoom);
            }
            else
            {
                Console.WriteLine($"{Name} cannot move that way");
            }

        }

        public abstract void SpecialAction(); // must have this method
    }
}
