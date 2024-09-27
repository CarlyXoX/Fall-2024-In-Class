using Class06_DIP.Data;
using Class06_DIP.Models;

namespace Class06_DIP.Services
{
    public class GameEngine
    {
        private readonly IContext _context;
        private readonly Player _player;
        private readonly Goblin _goblin;

        // default constructor
        public GameEngine(IContext context)
        {
            Console.WriteLine("Starting GameEngine");
            _context = context;
            _player = _context.Characters.OfType<Player>().First();
            _goblin = _context.Characters.OfType<Goblin>().First();
        }

        public void Run()
        {
            _player.Move();
            _goblin.Move();
        }
    }
}


