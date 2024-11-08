using Class11EntityLibrary.Data;

namespace Class11Console.Services
{
    public class GameEngine
    {
        private readonly GameContext _context;

        public GameEngine(GameContext context)
        {
            _context = context;
        }
        public void Run()
        {
            var player = _context.Characters.First(c => c.Name == "Sir Lancelot");
            var goblin = _context.Characters.First(c => c.Name == "Gob Boglin");

            player.Attack(goblin);
        }
    }
}
