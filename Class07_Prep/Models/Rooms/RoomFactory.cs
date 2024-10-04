namespace Class07_Prep.Models.Rooms
{
    public class RoomFactory : IRoomFactory
    {
        public IRoom CreateRoom(string roomType) 
        {
            switch (roomType)
            {
                case "treasure":
                    return new Room("Treasure Room", "Lots of gold");
                case "dungeon":
                    return new Room("Dungeon", "Dark and cold");
                case "entrance":
                    return new Room("Entrance", "A large entrance hall");
                default:
                    return new Room();
            }
        }
    }
}
