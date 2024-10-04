using Class07_Prep.Data;
using Class07_Prep.Models.Characters;
using Class07_Prep.Models.Rooms;

namespace Class07_Prep.Services
{
    public class GameEngine
    {
        private readonly IContext _context;
        private readonly IRoomFactory _roomFactory;
        private readonly CharacterBase _player;
        private readonly CharacterBase _goblin;

        public GameEngine(IContext context, IRoomFactory roomFactory)
        {
            Console.WriteLine("Starting GameEngine");
            _context = context;
            _roomFactory = roomFactory;

            _player = _context.Characters.OfType<Player>().First();
            _goblin = _context.Characters.OfType<Goblin>().First();
        }

        public void Run()
        {
            _goblin.Move();

            // setup the rooms
            var startingRoom = SetupRooms();
            // _player.CurrentRoom = startingRoom; // no longer accessible as protected
            _player.EnterRoom(startingRoom);

            // welcome the player
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome to room {startingRoom.Name}");
            Console.WriteLine($"{startingRoom.Description}");
            Console.ResetColor();

            // Look North
            //_player.Look(startingRoom.North);
            _player.Move("north");
            _player.Move("south");
            _player.Move("south");

        }

        public IRoom SetupRooms()
        {
            var treasureRoom = _roomFactory.CreateRoom("treasure");
            var dungeonRoom = _roomFactory.CreateRoom("dungeon");
            var entranceRoom = _roomFactory.CreateRoom("entrance");

            // link rooms together
            entranceRoom.North = treasureRoom;
            treasureRoom.South = entranceRoom;
            
            treasureRoom.West = dungeonRoom;
            dungeonRoom.East = treasureRoom;

            return entranceRoom;
        }
    }
}


